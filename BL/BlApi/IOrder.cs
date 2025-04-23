

namespace BlApi;

public interface IOrder
{
    List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int productId, int amount);
    void CalcTotalPriceForProduct(BO.ProductInOrder productInOrder);
    void CalcTotalPrice(BO.Order order);
    void DoOrder(BO.Order order);
    List<BO.SaleInProduct> SearchSaleForProduct(int productId, bool isClub, int amount);


}
