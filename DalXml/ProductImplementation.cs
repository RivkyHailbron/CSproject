using DalApi;
using DO;
using System.Reflection;
using System.Xml.Linq;
using System.Xml.Serialization;
using Tools;
namespace Dal;

internal class ProductImplementation : IProduct
{
    static object lockObject = new object();

    public int Create(Product item)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Attempting to create product: {item}");

        if (item == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Received null product");
            throw new DalExceptionNullReceived("Product");
        }

        List<Product> productsList = LoadProductFromXml();
        bool exists = productsList.Any(p => p.ID == item.ID);
        if (exists)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Product with ID {item.ID} already exists");
            throw new DalExceptionIdIsAlreadyExistInTheList("Product");
        }

        Product p = item with { ID = Config.NextValProduct };
        productsList.Add(p);
        StoreProductToXml(productsList);

        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Successfully created product: {p}");
        LogManager.Tabs = LogManager.Tabs.Substring(1);
        return p.ID;
    }

    public void Delete(int id)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Attempting to delete product with ID: {id}");

        lock (lockObject)
        {
            List<Product> productsList = LoadProductFromXml();
            try
            {
                Product? p = productsList.Single(p => p?.ID == id);
                productsList.Remove(p);
                StoreProductToXml(productsList);
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Successfully deleted product with ID: {id}");
            }
            catch
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Product with ID {id} does not exist");
                throw new DalExceptionIdDoesNotExistInTheList("Product");
            }
        }
        LogManager.Tabs = LogManager.Tabs.Substring(1);
    }

    public Product? Read(int id)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Attempting to read product with ID: {id}");

        try
        {
            List<Product> productsList = LoadProductFromXml();
            Product p = productsList.Single(p => p?.ID == id);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Successfully read product with ID: {id}");
            return p;
        }
        catch
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Product with ID {id} does not exist");
            throw new DalExceptionIdDoesNotExistInTheList("Product");
        }
        finally
        {
            LogManager.Tabs = LogManager.Tabs.Substring(1);
        }
    }

    public Product? Read(Func<Product, bool>? filter)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Attempting to read product with filter");

        List<Product> productsList = LoadProductFromXml();
        try
        {
            var product = productsList.Single(p => filter(p));
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Successfully read product with filter");
            return product;
        }
        catch
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "No product found with the provided filter");
            throw new DalExceptionNoValuesByCondition("Product");
        }
        finally
        {
            LogManager.Tabs = LogManager.Tabs.Substring(1);
        }
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Attempting to read all products");

        List<Product> productsList = LoadProductFromXml();
        if (filter == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "No filter provided, returning all products");
            return new List<Product?>(productsList);
        }

        var filteredProducts = productsList.Where(p => filter(p)).ToList();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Successfully read {filteredProducts.Count} products with the provided filter");
        LogManager.Tabs = LogManager.Tabs.Substring(1);
        return filteredProducts;
    }

    public void Update(Product item)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Attempting to update product: {item}");

        if (item == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Received null product");
            throw new DalExceptionNullReceived("Product");
        }

        List<Product> productsList = LoadProductFromXml();
        var existingProductIndex = productsList.FindIndex(c => c.ID == item.ID);

        if (existingProductIndex != -1)
        {
            productsList[existingProductIndex] = item;
            StoreProductToXml(productsList);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Successfully updated product: {item}");
        }
        else
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Product with ID {item.ID} does not exist for update");
            throw new DalExceptionIdDoesNotExistInTheList("Product");
        }
        LogManager.Tabs = LogManager.Tabs.Substring(1);
    }

    private List<Product> LoadProductFromXml()
    {
        try
        {
            List<Product> productsList;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            lock (lockObject)
            {
                using (FileStream fs = new FileStream("../xml/products.xml", FileMode.Open, FileAccess.Read))
                {
                    productsList = serializer.Deserialize(fs) as List<Product>;
                }
            }
            if (productsList == null)
            {
                productsList = new List<Product>();
            }
            return productsList;
        }
        catch
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Error reading from XML");
            throw new DalExceptionErrorInReadFromXml("Product");
        }
    }

    private void StoreProductToXml(List<Product> productsList)
    {
        try
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            lock (lockObject)
            {
                using (FileStream fs = new FileStream("../xml/products.xml", FileMode.Create, FileAccess.Write))
                {
                    serializer.Serialize(fs, productsList);
                }
            }
        }
        catch
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Error writing to XML");
            throw new DalExceptionErrorInWriteToXml("Product");
        }
    }
}