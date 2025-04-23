
using DalApi;
using System.Collections.Generic;
using static BO.Tools;

namespace Bllmplementation
{
    internal class ProductImplementation : BlApi.IProduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Product item)
        {
            try
            {
                DO.Product product = item.ConvertProductBOtoDO();
                return _dal.Product.Create(product);
            }
            catch (DO.DalExceptionIdDoesNotExistInTheList e)
            {
                throw new BO.BLExceptionIdDoesNotExistInTheList("Bl: ID is already exist \n ", e);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _dal.Product.Delete(id);
            }
            catch (DO.DalExceptionIdDoesNotExistInTheList e)
            {
                throw new BO.BLExceptionIdDoesNotExistInTheList("Bl: ID does not exist \n", e);
            }
        }

        public BO.Product? Read(int id)
        {
            try
            {
                DO.Product p = _dal.Product.Read(id);
                return p.ConvertProductDOToBO();
            }
            catch (DO.DalExceptionIdDoesNotExistInTheList e)
            {
                throw new BO.BLExceptionIdDoesNotExistInTheList("Bl: ID does not exist \n", e);
            }
        }

        public BO.Product? Read(Func<BO.Product, bool>? filter)
        {
            try
            {
                if (filter == null) return null;
                List<DO.Product> list = _dal.Product.ReadAll();

                DO.Product product = list.SingleOrDefault(p => filter(p.ConvertProductDOToBO()));
                return product.ConvertProductDOToBO();

                //var boList = list.Select(p => p.ConvertProductDOToBO()).Where(p => p != null).ToList();

                //// חיפוש עם בדיקה מראש ל- null
                //BO.Product? product = boList.SingleOrDefault(p => filter(p!));

                //return product;

            }
            catch (DO.DalExceptionNoValuesByCondition e)
            {
                throw new BO.BlExceptionNoValuesByCondition("", e);

            }
        }

        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            try
            {
                List<DO.Product?> listDO = _dal.Product.ReadAll();
                List<BO.Product?> listBO = (from p in listDO
                                            where filter == null || filter(p.ConvertProductDOToBO())
                                            select p.ConvertProductDOToBO()).ToList();
                return listBO;

            }
            catch (Exception e)
            {

                throw e;

            }
        }

        public void Update(BO.Product item)
        {
            _dal.Product.Update(item.ConvertProductBOtoDO());
        }
        public List<BO.SaleInProduct> ListOfValidSale(int productId, bool isClub)
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
                                               where s.EndDateSale >= DateTime.Now && s.StartDateSale <= DateTime.Now
                                               select new BO.SaleInProduct(s.ID, s.MinAmountForSale, s.SalePrice, s.ForClub)).ToList();

                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
