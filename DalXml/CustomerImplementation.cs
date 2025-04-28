using DalApi;
using DO;
using System.Reflection;
using System.Xml.Serialization;
using Tools; 

namespace Dal;

internal class CustomerImplementation : ICustomer
{
    static object lockObject = new object();

    private List<Customer> LoadCustomersListFromXml()
    {
        try
        {
            LogManager.Tabs += "\t";
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Loading customers list from XML");
            List<Customer> customersList;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            lock (lockObject)
            {
                using (FileStream fs = new FileStream("../xml/customers.xml", FileMode.Open, FileAccess.Read))
                {
                    customersList = serializer.Deserialize(fs) as List<Customer>;
                }
            }
            LogManager.Tabs = LogManager.Tabs.Substring(1);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Finished loading customers list from XML");

            return customersList ?? new List<Customer>();
        }
        catch
        {
            throw new DalExceptionErrorInReadFromXml("customer");
        }
    }

    private void StoreCustomersListToXml(List<Customer> customersList)
    {
        try
        {
            LogManager.Tabs += "\t";
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Storing customers list to XML");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            lock (lockObject)
            {
                using (FileStream fs = new FileStream("../xml/customers.xml", FileMode.Create, FileAccess.Write))
                {
                    serializer.Serialize(fs, customersList);
                }
            }
            LogManager.Tabs = LogManager.Tabs.Substring(1);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Finished storing customers list to XML");
        }
        catch
        {
            throw new DalExceptionErrorInWriteToXml("customer");
        }
    }

    public int Create(Customer item)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Create customer {item}");
        if (item == null)
        {
            throw new DalExceptionNullReceived("customer");
        }

        var customersList = LoadCustomersListFromXml();
        if (customersList.Any(c => c.ID == item.ID))
        {
            throw new DalExceptionIdIsAlreadyExistInTheList("customer");
        }
        customersList.Add(item);
        StoreCustomersListToXml(customersList);

        LogManager.Tabs = LogManager.Tabs.Substring(1);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Finished creating customer {item}");

        return item.ID;
    }

    public void Delete(int id)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Delete customer {id}");

        lock (lockObject)
        {
            var customersList = LoadCustomersListFromXml();
            try
            {
                Customer c = customersList.Single(c => c?.ID == id);
                customersList.Remove(c);
                StoreCustomersListToXml(customersList);
            }
            catch
            {
                throw new DalExceptionIdDoesNotExistInTheList("customer");
            }
        }

        LogManager.Tabs = LogManager.Tabs.Substring(1);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Finished deleting customer {id}");
    }

    public Customer? Read(int id)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read customer {id}");

        var customersList = LoadCustomersListFromXml();
        try
        {
            Customer c = customersList.Single(c => c?.ID == id);
            LogManager.Tabs = LogManager.Tabs.Substring(1);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Finished reading customer {id}");
            return c;
        }
        catch
        {
            throw new DalExceptionIdDoesNotExistInTheList("customer");
        }
    }

    public Customer? Read(Func<Customer, bool>? filter)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read customer with filter");

        if (filter == null) return null;
        var customersList = LoadCustomersListFromXml();
        try
        {
            var result = customersList.Single(c => filter(c));
            LogManager.Tabs = LogManager.Tabs.Substring(1);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Finished reading customer with filter");
            return result;
        }
        catch
        {
            throw new DalExceptionNoValuesByCondition("customer");
        }
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read all customers");

        var customersList = LoadCustomersListFromXml();
        var result = filter == null ? new List<Customer?>(customersList) : customersList.Where(c => filter(c)).ToList();

        LogManager.Tabs = LogManager.Tabs.Substring(1);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Finished reading all customers");

        return result;
    }

    public void Update(Customer item)
    {
        LogManager.Tabs += "\t";
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Update customer {item}");

        if (item == null)
        {
            throw new DalExceptionNullReceived("customer");
        }

        var customersList = LoadCustomersListFromXml();
        var index = customersList.FindIndex(c => c.ID == item.ID);
        if (index == -1)
        {
            throw new DalExceptionIdDoesNotExistInTheList("Customer not found.");
        }

        customersList[index] = item;
        StoreCustomersListToXml(customersList);

        LogManager.Tabs = LogManager.Tabs.Substring(1);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Finished updating customer {item}");
    }
}
