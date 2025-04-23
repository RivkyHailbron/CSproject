
namespace BO;

public class Order
{
    public bool IsClubCustomer { get; set; }

    public List<ProductInOrder> ListOfProductsOrder { get; set; }

    public double FinalPriceForPay { get; set; }

    public Order(bool IsClubCustomer)
    {
        this.FinalPriceForPay = 0;
        this.IsClubCustomer = IsClubCustomer;
        this.ListOfProductsOrder = new List<ProductInOrder>();
    }
    public override string ToString() => this.ToStringProperty();

}
