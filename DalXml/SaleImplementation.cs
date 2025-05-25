using DalApi;
using DO;
using System.Reflection;
using System.Xml.Serialization;
using Tools; // <-- מוסיפים גם כאן

namespace Dal;

internal class SaleImplementation : ISale
{
    static object lockObject = new object();

    private List<Sale> LoadSalesListFromXml()
    {
        try
        {
            LogManager.Tabs += "\t";
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Loading sales list from XML");

            List<Sale> salesList;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            lock (lockObject)
            {
                using (FileStream fs = new FileStream("../xml/sales.xml", FileMode.Open, FileAccess.Read))
                {
                    salesList = serializer.Deserialize(fs) as List<Sale>;
                }
            }

            LogManager.Tabs = LogManager.Tabs.Substring(1);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Finished loading sales list from XML");

            return salesList ?? new List<Sale>();
        }
        catch
        {
            throw new DalExceptionErrorInReadFromXml("sale");
        }
    }

    private void StoreSalesListToXml(List<Sale> salesList)
    {
        try
        {
            LogManager.Tabs += "\t";
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Storing sales list to XML");

            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            lock (lockObject)
            {
                using (FileStream fs = new FileStream("../xml/sales.xml", FileMode.Create, FileAccess.Write))
                {
                    serializer.Serialize(fs, salesList);
                }
            }

            LogManager.Tabs = LogManager.Tabs.Substring(1);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Finished storing sales list to XML");
        }
        catch
        {
            throw new DalExceptionErrorInWriteToXml("sale");
        }
    }

    public int Create(Sale item)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Attempting to create sale: {item}");

        if (item == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Received null sale");
            throw new DalExceptionNullReceived("Sale");
        }

        List<Sale> salesList = LoadSalesListFromXml();
        bool exists = salesList.Any(p => p.ID == item.ID);
        if (exists)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Sale with ID {item.ID} already exists");
            throw new DalExceptionIdIsAlreadyExistInTheList("Sale");
        }

        Sale p = item with { ID = Config.NextValSale };
        salesList.Add(p);
        StoreSalesListToXml(salesList);

        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Successfully created sale: {p}");
        LogManager.Tabs = LogManager.Tabs.Substring(1);
        return p.ID;
    }

    public void Delete(int id)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Delete sale {id}");

        lock (lockObject)
        {
            var salesList = LoadSalesListFromXml();
            try
            {
                Sale s = salesList.Single(s => s?.ID == id);
                salesList.Remove(s);
                StoreSalesListToXml(salesList);
            }
            catch
            {
                throw new DalExceptionIdDoesNotExistInTheList("sale");
            }
        }

        LogManager.Tabs = LogManager.Tabs.Substring(1);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Finished deleting sale {id}");
    }

    public Sale? Read(int id)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read sale {id}");

        var salesList = LoadSalesListFromXml();
        try
        {
            Sale s = salesList.Single(s => s?.ID == id);

            LogManager.Tabs = LogManager.Tabs.Substring(1);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Finished reading sale {id}");

            return s;
        }
        catch
        {
            throw new DalExceptionIdDoesNotExistInTheList("sale");
        }
    }

    public Sale? Read(Func<Sale, bool>? filter)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read sale with filter");

        if (filter == null) return null;

        var salesList = LoadSalesListFromXml();
        try
        {
            var result = salesList.Single(s => filter(s));

            LogManager.Tabs = LogManager.Tabs.Substring(1);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Finished reading sale with filter");

            return result;
        }
        catch
        {
            throw new DalExceptionNoValuesByCondition("sale");
        }
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read all sales");

        var salesList = LoadSalesListFromXml();
        var result = filter == null ? new List<Sale?>(salesList) : salesList.Where(s => filter(s)).ToList();

        LogManager.Tabs = LogManager.Tabs.Substring(1);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Finished reading all sales");

        return result;
    }

    public void Update(Sale item)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Update sale {item}");

        if (item == null)
        {
            throw new DalExceptionNullReceived("sale");
        }

        var salesList = LoadSalesListFromXml();
        var index = salesList.FindIndex(s => s.ID == item.ID);
        if (index == -1)
        {
            throw new DalExceptionIdDoesNotExistInTheList("sale");
        }

        salesList[index] = item;
        StoreSalesListToXml(salesList);

        LogManager.Tabs = LogManager.Tabs.Substring(1);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Finished updating sale {item}");
    }
}
