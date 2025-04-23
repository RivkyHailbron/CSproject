
namespace BO;

public class Sale
{
    public int ID { get; init; }

    public int ProductId { get; set; }

    public int MinAmountForSale { get; set; }

    public int SalePrice { get; set; }

    public bool ForClub { get; set; }

    public DateTime StartDateSale { get; set; }

    public DateTime EndDateSale { get; set; }

    public Sale(int ID, int ProductId, int MinAmountForSale, int SalePrice, bool ForClub, DateTime StartDateSale, DateTime EndDateSale)
    {
        this.ID = ID;
        this.ProductId = ProductId;
        this.MinAmountForSale = MinAmountForSale;
        this.SalePrice = SalePrice;
        this.ForClub = ForClub;
        this.StartDateSale = StartDateSale;
        this.EndDateSale = EndDateSale;
    }
    public override string ToString() => this.ToStringProperty();

}
