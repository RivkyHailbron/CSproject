
namespace BO;

public class Product
{

    public int ID { get; init; }
    public string Name { get; set; }
    public Categories Category { get; set; }
    public double Price { get; set; }
    public int Amount { get; set; }
    public List<SaleInProduct> ListOfSalesForProduct { get; set; }

    public Product(int id, string name, Categories category, double price, int amount)
    {
        this.ID = id;
        this.Name = name;
        this.Category = category;
        this.Price = price;
        this.Amount = amount;
       this.ListOfSalesForProduct = new List<SaleInProduct>();
    }
    public override string ToString() => this.ToStringProperty();

}
