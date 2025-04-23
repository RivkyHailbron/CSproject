
using System.Reflection;
using DalApi;
using DO;
using Tools;
namespace Dal;

internal class ProductImplementation : IProduct
{
    public int Create(Product? item)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"create product {item}");
        if (item == null)
        {
            throw new DalExceptionNullReceived("Product");
        }
        Product p = item with { ID = DataSource.Config.GetValProduct };
        DataSource.Products.Add(p);
        LogManager.Tabs = LogManager.Tabs.Substring(1);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"finish create product {item}");
        return p.ID;
    }

    public void Delete(int id)
    {

        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"delete  product {id}");
        Product? p = Read(id);
        DataSource.Products.Remove(p);
        LogManager.Tabs = LogManager.Tabs.Substring(1);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"finish delete product {id}");
    }

    public Product? Read(int id)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read product {id}");
        try
        {
            Product p = DataSource.Products.Single(p => p?.ID == id);
            LogManager.Tabs = LogManager.Tabs.Substring(1);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"finish read product {id}");
            return p;
        }
        catch
        {
            throw new DalExceptionIdDoesNotExistInTheList("Product");
        }

    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"readAll products ");
        if (filter == null)
        {
            return new List<Product?>(DataSource.Products);

        }
        LogManager.Tabs = LogManager.Tabs.Substring(1);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"finish readAll product ");
        return DataSource.Products.Where(p => filter(p)).ToList();


    }

    public void Update(Product? item)

    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"update product {item}");
        if (item == null)
        {
            throw new DalExceptionNullReceived("Product");
        }

        Delete(item.ID);
        DataSource.Products.Add(item);
        LogManager.Tabs = LogManager.Tabs.Substring(1);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"finish update product {item}");
    }

    public Product? Read(Func<Product, bool> filter)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read product with filter");
        if (filter == null) return null;
        LogManager.Tabs = LogManager.Tabs.Substring(1);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"finish read product with filter");
        try
        {
            return DataSource.Products.Single(p => filter(p));
        }
        catch
        {
            throw new DalExceptionNoValuesByCondition("customer");
        }
    }
}
