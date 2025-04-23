using DalApi;
using DO;
using Tools;
using System.Reflection;

namespace Dal;

internal class CustomerImplementation : ICustomer
{
    public int Create(Customer? item)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"create customer {item}");
        if (item == null)
        {
            throw new DalExceptionNullReceived("customer");
        }
        //בדיקה האם קיים אובייקט עם אותו מזהה
        bool b = DataSource.Customers.Any(c => c.ID == item.ID);

        if (b)
        {
            throw new DalExceptionIdIsAlreadyExistInTheList("customer");
        }

        DataSource.Customers.Add(item);


        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"finish create customer {item}");
        LogManager.Tabs = LogManager.Tabs.Substring(1);
        return item.ID;
    }

    public void Delete(int id)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"delete customer {id}");

        Customer c = Read(id);
        DataSource.Customers.Remove(c);

        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"finish delete customer {id}");
        LogManager.Tabs = LogManager.Tabs.Substring(1);

    }

    public Customer? Read(int id)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read customer {id}");
        try
        {

            Customer c = DataSource.Customers.Single(c => c?.ID == id);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"finish read customer {id}");
            LogManager.Tabs = LogManager.Tabs.Substring(1);
            return c;
        }
        catch
        {
            throw new DalExceptionIdDoesNotExistInTheList("customer");
        }



    }

    public List<Customer?> ReadAll(Func<Customer, bool> filter = null)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"readall customer ");
        if (filter == null)
        {
            return new List<Customer?>(DataSource.Customers);

        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"finish readAll customer ");
        LogManager.Tabs = LogManager.Tabs.Substring(1);

        return DataSource.Customers.Where(c => filter(c)).ToList();


    }

    public void Update(Customer? item)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"update customer {item}");
        if (item == null)
        {
            throw new DalExceptionNullReceived("customer");
        }
        Delete(item.ID);
        DataSource.Customers.Add(item);

        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"finish update customer {item}");
        LogManager.Tabs = LogManager.Tabs.Substring(1);
    }
    public Customer? Read(Func<Customer, bool> filter)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read customer with filter");
        if (filter == null) return null;
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"finish read customer with filter");
        LogManager.Tabs = LogManager.Tabs.Substring(1);
        try
        {
            return DataSource.Customers.Single(c => filter(c));
        }
        catch
        {
            throw new DalExceptionNoValuesByCondition("customer");
        }
       
    }
}
