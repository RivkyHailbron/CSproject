
using BO;
using static BO.Tools;


namespace BL;
internal class SaleImplementation : BlApi.ISale
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Sale item)
    {
        try
        {

            DO.Sale sale = item.ConvertSaleBOtoDO();
            return _dal.Sale.Create(sale);
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
            _dal.Sale.Delete(id);
        }
        catch (DO.DalExceptionIdDoesNotExistInTheList e)
        {
            throw new BO.BLExceptionIdDoesNotExistInTheList("Bl: ID does not exist \n", e);
        }
    }

    public BO.Sale? Read(int id)
    {
        try
        {
            DO.Sale sale = _dal.Sale.Read(id);
            return sale.ConvertSaleDOToBO();
        }
        catch (DO.DalExceptionIdDoesNotExistInTheList e)
        {
            throw new BO.BLExceptionIdDoesNotExistInTheList("Bl: ID does not exist \n", e);
        }
    }
    public BO.Sale? Read(Func<BO.Sale, bool>? filter)
    {
        try
        {
            if (filter == null) return null;

            List<DO.Sale> list = _dal.Sale.ReadAll();
            DO.Sale sale = list.Single<DO.Sale>(s => filter(s.ConvertSaleDOToBO()));
            return sale.ConvertSaleDOToBO();
        }
        catch (DO.DalExceptionNoValuesByCondition e)
        {
            throw new BO.BlExceptionNoValuesByCondition("", e);

        }
    }


    public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
    {
        try
        {
            List<DO.Sale?> listDO = _dal.Sale.ReadAll();
            List<BO.Sale?> listBO = (from p in listDO
                                     where filter == null || filter(p.ConvertSaleDOToBO())
                                     select p.ConvertSaleDOToBO()).ToList();
            return listBO;

        }
        catch (Exception e)
        {

            throw e;

        }
    }

    public void Update(BO.Sale item)
    {
        try
        {
            _dal.Sale.Update(item.ConvertSaleBOtoDO());
        }
        catch (Exception e)
        {
            throw e;
        }
    }
}
