

namespace BO;

public class ProductInOrder
{
    public int ProductId { get; init; }
    public string Name { get; set; }
    public double BasePrice { get; set; }
    public int Amount { get; set; }

    public List<SaleInProduct> ListOfSaleForProduct { get; set; }

    public double FinalPrice { get; set; }


    public ProductInOrder(int productId, string name, double basePrice, int amount)
    {
        this.ProductId = productId;
        this.Name = name;
        this.BasePrice = basePrice;
        this.Amount = amount;
        this.ListOfSaleForProduct = null;
        this.FinalPrice = 0;

    }
    public override string ToString() => this.ToStringProperty();


}
