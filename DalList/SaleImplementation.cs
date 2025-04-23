using DalApi;
using DO;
using System.Reflection;
using Tools;
namespace Dal;

internal class SaleImplementation : ISale
{
    public int Create(Sale? item)
    {

        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"create sale {item}");

        if (item == null)
            throw new DalExceptionNullReceived("sale");
        Sale? s = item with {ID= DataSource.Config.GetValSale};
        DataSource.Sales.Add(s);
        LogManager.Tabs=LogManager.Tabs.Substring(1);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"finish create sale {item}");

        return s.ID;
    }

    public void Delete(int id)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"delete sale {id}");

        Sale? s = Read(id);
        DataSource.Sales.Remove(s);

        LogManager.Tabs=LogManager.Tabs.Substring(1);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"finish delete sale {id}");

    }

    public Sale? Read(int id)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read sale{id}");

        try
        {
            Sale s = DataSource.Sales.Single(s => s?.ID == id);
            return s;
        }
        catch
        {
            throw new DalExceptionIdDoesNotExistInTheList("sale");
        }
        LogManager.Tabs=LogManager.Tabs.Substring(1);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"finish read sale {id}");

    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read sale by filter");

        if (filter == null)return null;
        LogManager.Tabs=LogManager.Tabs.Substring(1);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"finish read sale by filter");

        try
        {
            return DataSource.Sales.Single(c => filter(c));
        }
        catch
        {
            throw new DalExceptionNoValuesByCondition("sale");
        }
    }

    public List<Sale?> ReadAll(Func<Sale,bool>? filter=null)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "readAll sales");

        LogManager.Tabs=LogManager.Tabs.Substring(1);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"finish readAll sales");

        if (filter == null)
            return new List<Sale?>(DataSource.Sales);
        return DataSource.Sales.Where(s => filter(s)).ToList();

        
    }

    public void Update(Sale? item)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"update sale {item}");

        if (item == null)
        {
            throw new DalExceptionNullReceived("sale");
        }

  
        Delete(item.ID);
        DataSource.Sales.Add(item);

        LogManager.Tabs=LogManager.Tabs.Substring(1);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"finish update sale {item}");

    }
}
