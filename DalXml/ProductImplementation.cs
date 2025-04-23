

using DalApi;
using DO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Dal;

internal class ProductImplementation : IProduct
{
    static object lockObject = new object();
    public int Create(Product item)
    {
        if (item == null)
        {
            throw new DalExceptionNullReceived("Product");
        }

        List<Product> productsList = LoadProductFromXml();
        //בדיקה האם קיים אובייקט עם אותו מזהה
        bool b = productsList.Any(p => p.ID == item.ID);
        if (b)
        {
            throw new DalExceptionIdIsAlreadyExistInTheList("Product");
        }
        //הוספת המוצר החדש לרשימה
        Product p = item with { ID = Config.NextValProduct };
        productsList.Add(p);
        //כתיבת רשימת המוצרים לxml
        StoreProductToXml(productsList);
        return p.ID;

    }

    public void Delete(int id)
    {
        lock (lockObject)
        {
            List<Product> productsList = LoadProductFromXml();
            try
            {
                Product? p = productsList.Single(p => p?.ID == id);
                productsList.Remove(p);
                StoreProductToXml(productsList);
            }
            catch
            {
                throw new DalExceptionIdDoesNotExistInTheList("customer");
            }
        }

    }

    public Product? Read(int id)
    {
        try
        {
            List<Product> productsList = LoadProductFromXml();
            Product p = productsList.Single(p => p?.ID == id);
            StoreProductToXml(productsList);
            return p;
        }
        catch
        {
            throw new DalExceptionIdDoesNotExistInTheList("Product");
        }

    }

    public Product? Read(Func<Product, bool>? filter)
    {
        List<Product> productsList = LoadProductFromXml();

        StoreProductToXml(productsList);
        try
        {
            return productsList.Single(p => filter(p));
        }
        catch
        {
            throw new DalExceptionNoValuesByCondition("customer");
        }
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {

        List<Product> productsList;
        productsList = LoadProductFromXml();

        if (filter == null)
        {
            return new List<Product?>(productsList);

        }
        return productsList.Where(p => filter(p)).ToList();
    }

    public void Update(Product item)
    {


        if (item == null)
        {
            throw new DalExceptionNullReceived("Product");
        }
        List<Product> productsList = LoadProductFromXml();

        // חיפוש הלקוח ברשימה לפי ה-ID
        var existingProductIndex = productsList.FindIndex(c => c.ID == item.ID);
        if (existingProductIndex != -1)
        {
            // יצירת מוצר חדש עם הנתונים המעודכנים
            var updatedCustomer = new Product(item.ID, item.Name, item.Category, item.Price, item.Amount);

            // עדכון הרשימה עם הלקוח המעודכן
            productsList[existingProductIndex] = updatedCustomer;
        }
        else
        {
            throw new DalExceptionIdDoesNotExistInTheList("Product not found.");
        }

        StoreProductToXml(productsList);
    }


    private List<Product> LoadProductFromXml()
    {
        try
        {
            List<Product> productsList;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            //קריאת הנתונים מהxml
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
                //שומרים את הרשימה חזרה בקובץ הXML
                using (FileStream fs = new FileStream("../xml/products.xml", FileMode.Create, FileAccess.Write))
                {
                    serializer.Serialize(fs, productsList);
                }
            }
        }
        catch
        {
            throw new DalExceptionErrorInWriteToXml("Product");
        }
    }
}
