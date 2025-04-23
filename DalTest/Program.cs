using Dal;
using DalApi;
using DO;
using System.Reflection;
using Tools;

namespace DalTest;

public delegate bool filter(IDal t);
internal class Program
{
    //public static bool filterd()
    private static IDal s_dal = DalApi.Factory.Get;
    //•	מתודה פרטית שמציגה את התפריט הראשי
    public static int PrintMainMenu()
    {
        int select;
        Console.WriteLine("for product press 1");
        Console.WriteLine("for customer press 2");
        Console.WriteLine("for sale press 3");
        Console.WriteLine("to exit press 0");
        Console.WriteLine("to clean log press 4");


        if (!int.TryParse(Console.ReadLine(), out select))
            select = -1;
        return select;
    }
    //•	מתודה פרטית שמציגה את תת-תפריט של אפשריות CRUD, שמקבלת כפרמטר מחרוזת עם שם הישות
    public static int PrintSubMenu(string item)
    {
        int select;
        Console.WriteLine($"to add {item} press 1");
        Console.WriteLine($"to read {item} press 2");
        Console.WriteLine($"to read all {item} press 3");
        Console.WriteLine($"to update {item} press 4");
        Console.WriteLine($"to delete {item} press 5");
        Console.WriteLine($"to exit {item} press 0");

        if (!int.TryParse(Console.ReadLine(), out select))
            select = -1;
        return select;
    }
    //•	מתודה פרטית לקליטה ויצירת כל ישות
    //product
    public static void ProductMenu()
    {
        int subSelect = PrintSubMenu("Product");
        while (subSelect != 0)
        {
            switch (subSelect)
            {
                case 1:
                    s_dal.Product.Create(GetNewProduct());
                    break;
                case 2:
                    Console.WriteLine(s_dal.Product.Read(GetID("read")));
                    break;
                case 3:
                    PrintAll<Product>(s_dal.Product.ReadAll());
                    break;
                case 4:
                    Console.WriteLine("insert code");
                    int code;
                    int.TryParse(Console.ReadLine(), out code);
                    s_dal.Product.Update(GetNewProduct(code));
                    break;
                case 5:
                    s_dal.Product.Delete(GetID("delete"));
                    break;

                default:
                    Console.WriteLine("wrong sub select");
                    break;
            }
            subSelect = PrintSubMenu("Product");

        }

    }
    public static Product GetNewProduct(int code = 0)
    {
        Categories category;
        Console.WriteLine("insert name");
        string? name = Console.ReadLine();
        Console.WriteLine("insert category 0-4");
        int c;
        if (!int.TryParse(Console.ReadLine(), out c)) category = 0;
        else
            category = (Categories)c;
        Console.WriteLine("insert price");
        double p;
        double.TryParse(Console.ReadLine(), out p);
        Console.WriteLine("insert amount");
        int a;
        int.TryParse(Console.ReadLine(), out a);

        return new Product(code, name, category, p, a);
    }
    //customer
    public static void CustomerMenu()
    {
        int subSelect = PrintSubMenu("Customer");
        while (subSelect != 0)
        {
            switch (subSelect)
            {
                case 1:
                    s_dal.Customer.Create(GetNewCustomer());
                    break;
                case 2:
                    Console.WriteLine(s_dal.Customer.Read(GetID("read")));
                    break;
                case 3:
                    PrintAll<Customer>(s_dal.Customer.ReadAll());
                    break;
                case 4:

                    Console.WriteLine("insert id");
                    int id;
                    int.TryParse(Console.ReadLine(), out id);
                    s_dal.Customer.Update(GetNewCustomer(id));
                    break;
                case 5:
                    s_dal.Customer.Delete(GetID("delete"));
                    break;

                default:
                    Console.WriteLine("wrong sub select");
                    break;
            }
            subSelect = PrintSubMenu("Customer");

        }

    }
    public static Customer GetNewCustomer(int id = 0)
    {
        Console.WriteLine("insert id");
        int.TryParse(Console.ReadLine(), out id);
        Console.WriteLine("insert name");
        string? name = (Console.ReadLine());
        Console.WriteLine("insert adress");
        string? adress = (Console.ReadLine());
        Console.WriteLine("insert phone");
        string? phone = (Console.ReadLine());
        return new Customer(id, name, adress, phone);
    }
    //sale
    public static void SaleMenu()
    {
        int subSelect = PrintSubMenu("Sale");
        while (subSelect != 0)
        {
            switch (subSelect)
            {
                case 1:
                    s_dal.Sale.Create(GetNewSale());
                    break;
                case 2:
                    Console.WriteLine(s_dal.Sale.Read(GetID("read")));
                    break;
                case 3:
                    PrintAll<Sale>(s_dal.Sale.ReadAll());
                    break;
                case 4:

                    Console.WriteLine("insert codeSale");
                    int codeSale;
                    int.TryParse(Console.ReadLine(), out codeSale);
                    s_dal.Sale.Update(GetNewSale(codeSale));
                    break;
                case 5:
                    s_dal.Sale.Delete(GetID("delete"));
                    break;

                default:
                    Console.WriteLine("wrong sub select");
                    break;
            }
            subSelect = PrintSubMenu("Sale");

        }

    }
    public static Sale GetNewSale(int codeSale = 0)
    {

        Console.WriteLine("insert product id");
        int productId;
        int.TryParse(Console.ReadLine(), out productId);
        Console.WriteLine("insert Min Amount For Sale");
        int MinAmountForSale;
        int.TryParse(Console.ReadLine(), out MinAmountForSale);
        Console.WriteLine("insert  Sale price");
        int SalePrice;
        int.TryParse(Console.ReadLine(), out SalePrice);
        Console.WriteLine("insert  ForClub 1 or 0");
        bool ForClub;
        bool.TryParse(Console.ReadLine(), out ForClub);
        Console.WriteLine("insert StartDateSale-days for start");
        int StartDateSale;
        int.TryParse(Console.ReadLine(), out StartDateSale);

        Console.WriteLine("insert EndDateSale-days for end");
        int EndDateSale;
        int.TryParse(Console.ReadLine(), out EndDateSale);
        return new Sale(codeSale, productId, MinAmountForSale, SalePrice, ForClub, DateTime.Now.AddDays(StartDateSale), DateTime.Now.AddDays(EndDateSale));
    }
    //2 fuctions for all entities
    public static void PrintAll<T>(List<T> l)
    {
        if (l is null)
        {
            throw new ArgumentNullException(nameof(l));
        }

        foreach (T item in l)
        {
            Console.WriteLine(item);
        }

    }
    public static int GetID(string crud)
    {
        Console.WriteLine($"insert id for {crud}");
        int ID;
        int.TryParse(Console.ReadLine(), out ID);
        return ID;
    }
    static void Main(string[] args)
    {
        //Initialization.Initialize();
        try
        {

            int select = PrintMainMenu();
            while (select != 0)
            {
                switch (select)
                {
                    case 1:
                        Console.WriteLine("product");
                        ProductMenu();

                        break;
                    case 2:
                        Console.WriteLine("customer");
                        CustomerMenu();

                        break;
                    case 3:
                        Console.WriteLine("sale");
                        SaleMenu();

                        break;
                    case 4:
                        Console.WriteLine("clean");
                        LogManager.CleanLogFolder();

                        break;
                    default:
                        Console.WriteLine("wrong select, select again");
                        break;
                }
                select = PrintMainMenu();

            }


        }
        catch (Exception ex)
        {
            LogManager.Tabs += "\t";
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"throw {ex}");
            throw ex;
        }

    }
}