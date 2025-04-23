
using System.Reflection;
using System.Text;

namespace BO;
internal static class Tools
{
    //פונקציות המרה מישויות BO לDO ולהיפך
    public static DO.Customer ConvertCustomerBOtoDO(this BO.Customer customerBO)
    {
        
        DO.Customer customerDO = new DO.Customer(customerBO.ID, customerBO.Name, customerBO.Address, customerBO.Phone); ;
        return customerDO; 
    }
    public static DO.Product ConvertProductBOtoDO(this BO.Product productBO)
    {
        
        DO.Product productDO = new DO.Product(productBO.ID,productBO.Name,(DO.Categories)productBO.Category,productBO.Price,productBO.Amount); ;
        return productDO;
    }
   
    public static DO.Sale ConvertSaleBOtoDO(this BO.Sale saleBO)
    {
        DO.Sale saleDO = new DO.Sale(saleBO.ID, saleBO.ProductId, saleBO.MinAmountForSale, saleBO.SalePrice, saleBO.ForClub, saleBO.StartDateSale, saleBO.EndDateSale) ;

        return saleDO;
    }
    public static BO.Customer ConvertCustomerDOToBO(this DO.Customer customerDO)
    {
        return new BO.Customer(customerDO.ID, customerDO.Name, customerDO.Address, customerDO.Phone);
    }

    public static BO.Product ConvertProductDOToBO(this DO.Product productDO)
    {
        return new BO.Product(productDO.ID, productDO.Name, (BO.Categories)productDO.Category, productDO.Price, productDO.Amount);
    }

    public static BO.Sale ConvertSaleDOToBO(this DO.Sale saleDO)
    {

        return new BO.Sale(saleDO.ID, saleDO.ProductId, saleDO.MinAmountForSale, saleDO.SalePrice, saleDO.ForClub, saleDO.StartDateSale, saleDO.EndDateSale);
    }

    public static string ToStringProperty<T>(this T obj, string prefix = "")
    {
        StringBuilder sb = new StringBuilder();
        Type t = obj?.GetType() ?? throw new Exception("Obj is NULL");
        foreach (PropertyInfo prop in t.GetProperties())
        {
            //if (prop.PropertyType.IsPrimitive
            //    || prop.PropertyType == typeof(string)
            //    || prop.PropertyType == typeof(DateTime)
            //    || prop.PropertyType == typeof(BO.Categories))
                sb.AppendLine($"{prefix}{prop.Name} = {prop.GetValue(obj)}");
            //else
            //    sb.Append($"{prefix}{prop.Name} =\n{prop.GetValue(obj).ToStringProperty(prefix + "\t")}");
        }
        return sb.ToString();
    }

}
