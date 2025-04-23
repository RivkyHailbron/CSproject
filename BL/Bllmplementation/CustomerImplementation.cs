

using static BO.Tools;
namespace Bllmplementation;

internal class CustomerImplementation : BlApi.ICustomer
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Customer item)
    {
        try
        {
            DO.Customer customer = item.ConvertCustomerBOtoDO();
            return _dal.Customer.Create(customer);
        }
        catch (DO.DalExceptionIdIsAlreadyExistInTheList e)
        {
            throw new BO.BLExceptionIdIsAlreadyExistInTheList("Bl: ID is already exist \n ", e);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _dal.Customer.Delete(id);
        }
        catch (DO.DalExceptionIdDoesNotExistInTheList e)
        {
            throw new BO.BLExceptionIdDoesNotExistInTheList("Bl: ID does not exist \n", e);
        }
    }

    public BO.Customer? Read(int id)
    {
        try
        {
            DO.Customer c = _dal.Customer.Read(id);
            return c.ConvertCustomerDOToBO();
        }
        catch (DO.DalExceptionIdDoesNotExistInTheList e)
        {
            throw new BO.BLExceptionIdDoesNotExistInTheList("Bl: ID does not exist \n", e);
        }

    }

    public BO.Customer? Read(Func<BO.Customer, bool>? filter)
    {
        try
        {
            if (filter == null) return null;
            List<DO.Customer> list = _dal.Customer.ReadAll();

            DO.Customer customer = list.Single<DO.Customer>(c => filter(c.ConvertCustomerDOToBO()));
            return customer.ConvertCustomerDOToBO();

        }
        catch (DO.DalExceptionNoValuesByCondition e)
        {
            throw new BO.BlExceptionNoValuesByCondition("", e);

        }


    }

    public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
    {

        try
        {


            List<DO.Customer?> listDO = _dal.Customer.ReadAll();
            List<BO.Customer?> listBO = (from c in listDO
                                         where filter == null || filter(c.ConvertCustomerDOToBO())
                                         select c.ConvertCustomerDOToBO()).ToList();
            return listBO;

        }
        catch (Exception e)
        {

            throw e;

        }
    }

    public void Update(BO.Customer item)
    {

        try
        {
            _dal.Customer.Update(item.ConvertCustomerBOtoDO());
        }
        catch (DO.DalExceptionNullReceived e)
        {
            throw new BO.BLExceptionNullReceived("null recieved", e);

        }
        catch (DO.DalExceptionIdDoesNotExistInTheList e)
        {
            throw new BO.BLExceptionIdDoesNotExistInTheList("Bl: ID does not exist \n", e);
        }
        catch (Exception e)
        {
            throw e;
        }



    }
    public bool IsCustomerExist(int id)
    {
        try
        {
            List<DO.Customer> customres = _dal.Customer.ReadAll();
            return customres.Exists(c => c.ID == id);
        }
        catch (Exception e)
        {

            throw e;

        }

    }
}