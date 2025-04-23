


using static BO.Tools;
namespace BL;
internal class OrderImplementation : BlApi.IOrder
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    //עדכון המבצעים המתאימים למוצר בהזמנה
    public List<BO.SaleInProduct> SearchSaleForProduct(int productId, bool isClub, int amount)
    {

        try
        {
            List<DO.Sale> sales = _dal.Sale.ReadAll();
            sales = (from s in sales
                     where s.ProductId == productId
                     select s).ToList();
            if (!isClub)
            {
                sales = sales.FindAll(s => !s.ForClub);
            }
            List<BO.SaleInProduct> list = (from s in sales
                                           where s.EndDateSale >= DateTime.Now && s.StartDateSale <= DateTime.Now && amount >= s.MinAmountForSale
                                           orderby s.SalePrice / s.MinAmountForSale
                                           select new BO.SaleInProduct(s.ID, s.MinAmountForSale, s.SalePrice, s.ForClub)).ToList();

            return list;
        }
        catch
        {
            throw new Exception();
        }
    }

    //חישוב המחיר לתשלום עבור מוצר בהזמנה, כולל מימוש מבצעים.

    public void CalcTotalPriceForProduct(BO.ProductInOrder productInOrder)
    {

        try
        {
            int count = productInOrder.Amount;
            double totalSum = 0;
            int max;
            List<BO.SaleInProduct> salesList = new List<BO.SaleInProduct>();
            foreach (BO.SaleInProduct sale in productInOrder.ListOfSaleForProduct)
            {
                if (count <= 0)
                    break;
                if (sale.MinAmountOfSale <= count)
                {
                    max = count / sale.MinAmountOfSale;
                    totalSum += max * sale.Price;
                    count -= max * sale.MinAmountOfSale; // עדכן את count בהתאם
                    salesList.Add(sale);
                }

            }
            if (count > 0)
            {
                totalSum += (productInOrder.BasePrice * count);

            }
            productInOrder.ListOfSaleForProduct = salesList;
            productInOrder.FinalPrice = totalSum;
        }
        catch
        {
            throw;

        }
    }

    //חישוב הסכום הסופי לתשלום להזמנה.
    public void CalcTotalPrice(BO.Order order)
    {
        try
        {
            order.FinalPriceForPay = order.ListOfProductsOrder.Sum(p => p.FinalPrice);
        }
        catch
        {
            throw new Exception();
        }
    }
    public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int productId, int amount)
    {
        try
        {
            DO.Product productInStock = _dal.Product.Read(productId);
            BO.ProductInOrder product;
            product = order.ListOfProductsOrder.FirstOrDefault<BO.ProductInOrder>(p => p.ProductId == productId);

            if (product == null)
            {
                product = new BO.ProductInOrder(productId, productInStock.Name, productInStock.Price, 0);
                order.ListOfProductsOrder.Add(product);
            }

            if (productInStock.Amount < amount + product.Amount)
            {
                throw new BO.BLExceptionNotEnoughInStock(product.Name);
            }

            product.Amount += amount;

            // עדכון המבצעים לאחר הוספת הכמות
            product.ListOfSaleForProduct = SearchSaleForProduct(productId, order.IsClubCustomer, product.Amount);

            // חישוב המחיר לאחר עדכון המבצעים
            CalcTotalPriceForProduct(product);

            // חישוב הסכום הסופי להזמנה
            CalcTotalPrice(order);

            return product.ListOfSaleForProduct;
        }
        catch (Exception e)
        {
            throw e;
        }
    }




    //  מקבלת כפרמטר הזמנה ולא מחזירה ערך
    public void DoOrder(BO.Order order)
    {
        try
        {
            foreach (BO.ProductInOrder productInOrder in order.ListOfProductsOrder)
            {
                DO.Product product = _dal.Product.Read(productInOrder.ProductId);
                BO.Product p = product.ConvertProductDOToBO();
                p.Amount -= productInOrder.Amount;
                _dal.Product.Update(p.ConvertProductBOtoDO());
            }
        }
        catch (Exception e)
        {
            throw e;
        }
    }


}
