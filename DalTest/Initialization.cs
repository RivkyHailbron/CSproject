using Dal;
using DalApi;
using DO;

namespace DalTest;

public static class Initialization
{
    private static IDal s_dal;
    private static void CreateProducts()
    {
        s_dal.Product.Create(new Product(0, "lack shoes black to shabes for girls", Categories.elegant, 100, 200));
        s_dal.Product.Create(new Product(0, "sport shoes gray for girls", Categories.sport, 250, 4000));
        s_dal.Product.Create(new Product(0, "mokasin shoes brown", Categories.women, 100, 2500));
        s_dal.Product.Create(new Product(0, "crocs shoes", Categories.men, 60, 700));
        s_dal.Product.Create(new Product(0, "first step white-red for children", Categories.children, 180, 1100));
        s_dal.Product.Create(new Product(0, "comfortable shoes", Categories.sport, 300, 500));
    }


    private static void CreateCustomers()
    {
        s_dal.Customer.Create(new Customer(111, "Yeuda", "Modin ilit", "0556767677"));
        s_dal.Customer.Create(new Customer(222, "Rivki", "Jerusalem", "0556764658"));
        s_dal.Customer.Create(new Customer(333, "Rut", "Bne Brak", "0556744258"));
        s_dal.Customer.Create(new Customer(444, "Michal", "Modin ilit", "0556722714"));
        s_dal.Customer.Create(new Customer(555, "Chaim", "Jerusalem", "0583244056"));
        s_dal.Customer.Create(new Customer(666, "Michael", "Jerusalem", "0527634508"));
    }
    private static void CreateSales()
    {
        s_dal.Sale.Create(new Sale(0, 1, 2, 180, true, DateTime.Now, DateTime.Now.AddDays(30)));
        s_dal.Sale.Create(new Sale(0, 1, 3, 250, false, DateTime.Now, DateTime.Now.AddDays(15)));
        s_dal.Sale.Create(new Sale(0, 2, 2, 450, true, DateTime.Now, DateTime.Now.AddDays(30)));
        s_dal.Sale.Create(new Sale(0, 2, 3, 700, true, DateTime.Now, DateTime.Now.AddDays(30)));
        s_dal.Sale.Create(new Sale(0, 3, 2, 150, false, DateTime.Now, DateTime.Now.AddDays(10)));
        s_dal.Sale.Create(new Sale(0, 4, 1, 35, false, DateTime.Now, DateTime.Now.AddDays(10)));
        s_dal.Sale.Create(new Sale(0, 4, 2, 50, false, DateTime.Now, DateTime.Now.AddDays(10)));
        s_dal.Sale.Create(new Sale(0, 5, 1, 150, true, DateTime.Now, DateTime.Now.AddDays(30)));
        s_dal.Sale.Create(new Sale(0, 5, 2, 250, true, DateTime.Now, DateTime.Now.AddDays(30)));
        s_dal.Sale.Create(new Sale(0, 6, 1, 280, true, DateTime.Now, DateTime.Now.AddDays(60)));
        s_dal.Sale.Create(new Sale(0, 6, 2, 500, true, DateTime.Now, DateTime.Now.AddDays(60)));

    }
    public static void Initialize()
    {
        s_dal = DalApi.Factory.Get;
        CreateCustomers();
        CreateProducts();
        CreateSales();
    }
}
