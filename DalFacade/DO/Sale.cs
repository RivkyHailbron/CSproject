
namespace DO;

public record Sale
(   int ID,
    int ProductId,
    int MinAmountForSale,
    int SalePrice,
    bool ForClub,
    DateTime StartDateSale,
    DateTime EndDateSale)
{
    public Sale() : this(0, 0, 0, 0, false, DateTime.Now, DateTime.Now)
    {

    }
}
