

namespace BO;

public class SaleInProduct
{
    public int ID { get; init; }
    public int MinAmountOfSale { get; set; }
    public double Price { get; set; }
    public bool ForClub { get; set; }

    public SaleInProduct(int id, int minAmountOfSale, double price, bool ForClub)
    {
        this.ID = id;
        this.MinAmountOfSale = minAmountOfSale;
        this.Price = price;
        this.ForClub = ForClub;        
    }
    public override string ToString() => this.ToStringProperty();




}
