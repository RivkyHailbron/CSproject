using DalTest;
public static class Program
{
    static readonly BlApi.IBl s_bl = BlApi.Factory.Get();
    static BO.Order order = new BO.Order(false);
    //קליטת ת.ז. של לקוח 
    public static int GetCustomerID()
    {
        Console.WriteLine($"Insert Id");
        int id;
        while (!int.TryParse(Console.ReadLine(), out id))
            Console.WriteLine("Invalid id, please try again");
        return id;
    }
    //קליטת המוצרים להזמנה: לכל מוצר מזהה וכמות להזמנה.
    public static List<BO.SaleInProduct> GetProduct()
    {
        try
        {
            //קליטת מזהה מוצר וכמות להזמנה
            Console.WriteLine($"Insert id of product");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
                Console.WriteLine("Invalid id, please try again");

            Console.WriteLine($"Insert amount of ordre ");
            int amount;
            while (!int.TryParse(Console.ReadLine(), out amount))
                Console.WriteLine("Invalid amount, please try again");

            return s_bl.Order.AddProductToOrder(order, id, amount);
        }
        catch (BO.BLExceptionNotEnoughInStock ex) // נתפוס מחסור במלאי
        {
            Console.WriteLine($"Error: Not enough stock for {ex.Message}. Please try again.");
            return new List<BO.SaleInProduct>(); // מחזירים רשימה ריקה במקום לקרוס
        }
        catch (Exception e) // נתפוס כל שגיאה אחרת
        {
            Console.WriteLine($"Unexpected error: {e.Message}");
            return new List<BO.SaleInProduct>(); // כדי שהתוכנית תמשיך לרוץ
        }
    }
    public static void GetProducts()
    {

        int select;
        do
        {
            List<BO.SaleInProduct> list = GetProduct();
            foreach (BO.SaleInProduct item in list)
            {
                Console.WriteLine("");
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine($"the total sum now is:{order.FinalPriceForPay}");
            Console.WriteLine("for more product press 1, for finish press 0");
        }
        while (int.TryParse(Console.ReadLine(), out select) && select != 0);
    }
    public static void Main()
    {
        Console.WriteLine("Hello in bL!");
        Console.WriteLine("to initialize press v");
        string init = Console.ReadLine();
        if (init == "v")
            Initialization.Initialize();
        List<BO.Product?> l = (s_bl.Product.ReadAll());
        Console.WriteLine(string.Join("\n", l));

        int select;

        do
        {
            order = new BO.Order(false);
            int id = GetCustomerID();
            if (s_bl.Customer.IsCustomerExist(id))
            {
                order.IsClubCustomer = true;
                Console.WriteLine($"hellow ,{s_bl.Customer.Read(id)!.Name}");
            }
            GetProducts();
            s_bl.Order.DoOrder(order);
            List<BO.ProductInOrder> list = order.ListOfProductsOrder;
            foreach (BO.ProductInOrder item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"the total sum now is:{order.FinalPriceForPay}");
            Console.WriteLine("for more order press 1, for exit press 0");
        }
        while (int.TryParse(Console.ReadLine(), out select) && select != 0);

    }
}