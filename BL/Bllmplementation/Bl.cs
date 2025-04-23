using BL;
using BlApi;


namespace Bllmplementation;

internal class Bl : IBl
{
    public ICustomer Customer => new CustomerImplementation();

    public IProduct Product => new ProductImplementation();

    public ISale Sale =>  new SaleImplementation();

    public IOrder Order =>  new OrderImplementation();
}
