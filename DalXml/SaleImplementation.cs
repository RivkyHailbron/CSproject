

using DalApi;
using DO;
using System.Xml.Linq;

namespace Dal;

internal class SaleImplementation : ISale
{
    private const string ID = "ID";
    private const string PRODUCT_ID = "ProductId";
    private const string MIN_AMOUNT_FOR_SALE = "MinAmountForSale";
    private const string SALE_PRICE = "SalePrice";
    private const string FOR_CLUB = "ForClub";
    private const string START_DATE_SALE = "StartDateSale";
    private const string END_DATE_SALE = "EndDateSale";
    private const string FILE_PATH = "../xml/sals.xml";
    private const string CLASS = "Sale";
    //private const string ARRAY_OF_SALE = "ArrayOfSale";

    public int Create(Sale item)
    {
        try
        {
            if (item == null)
                throw new DalExceptionNullReceived("sale");

            XElement salesXml = XElement.Load(FILE_PATH);
            Sale? s = item with { ID = Config.NextValSale };

            salesXml.Add(new XElement(CLASS,
                 new XElement(ID, s.ID),
                 new XElement(PRODUCT_ID, s.ProductId),
                 new XElement(MIN_AMOUNT_FOR_SALE, s.MinAmountForSale),
                 new XElement(SALE_PRICE, s.SalePrice),
                 new XElement(FOR_CLUB, s.ForClub),
                 new XElement(START_DATE_SALE, s.StartDateSale),
                 new XElement(END_DATE_SALE, s.EndDateSale)));
            salesXml.Save(FILE_PATH);
            return s.ID;
        }
        catch
        {
            throw new DalExceptionErrorInWriteToXml("customer");
        }

    }

    public void Delete(int id)
    {
        XElement salesXml = XElement.Load(FILE_PATH);
        //שאם לא קיים שיפול בREAD
        Read(id);

        var elementToRemove = salesXml.Elements(CLASS).FirstOrDefault(s => int.Parse(s.Element(ID).Value) == id);

        elementToRemove.Remove();

        salesXml.Save(FILE_PATH);
    }

    public Sale? Read(int id)
    {
        XElement salesXml = XElement.Load(FILE_PATH);
        var element = salesXml.Elements(CLASS).FirstOrDefault(s => int.Parse(s.Element(ID).Value) == id);
        if (element == null)
            throw new DalExceptionIdDoesNotExistInTheList("sale");

        Sale sale = new Sale()
        {
            ID = int.Parse(element.Element(ID).Value),
            ProductId = int.Parse(element.Element(PRODUCT_ID).Value),
            MinAmountForSale = int.Parse(element.Element(MIN_AMOUNT_FOR_SALE).Value),
            SalePrice = int.Parse(element.Element(SALE_PRICE).Value),
            ForClub = bool.Parse(element.Element(FOR_CLUB).Value),
            StartDateSale = DateTime.Parse(element.Element(START_DATE_SALE).Value),
            EndDateSale = DateTime.Parse(element.Element(END_DATE_SALE).Value)
        };
        return sale;
    }


    public Sale? Read(Func<Sale, bool>? filter)
    {
        XElement salesXml = XElement.Load(FILE_PATH);
        var element = salesXml.Elements(CLASS).FirstOrDefault(s=> filter(
        new Sale()
        {
            ID = int.Parse(s.Element(ID).Value),
            ProductId = int.Parse(s.Element(PRODUCT_ID).Value),
            MinAmountForSale = int.Parse(s.Element(MIN_AMOUNT_FOR_SALE).Value),
            SalePrice = int.Parse(s.Element(SALE_PRICE).Value),
            ForClub = bool.Parse(s.Element(FOR_CLUB).Value),
            StartDateSale = DateTime.Parse(s.Element(START_DATE_SALE).Value),
            EndDateSale = DateTime.Parse(s.Element(END_DATE_SALE).Value)
        }));
        if (element == null)
            throw new DalExceptionNoValuesByCondition("sale");

        Sale sale = new Sale()
        {
            ID = int.Parse(element.Element(ID).Value),
            ProductId = int.Parse(element.Element(PRODUCT_ID).Value),
            MinAmountForSale = int.Parse(element.Element(MIN_AMOUNT_FOR_SALE).Value),
            SalePrice = int.Parse(element.Element(SALE_PRICE).Value),
            ForClub = bool.Parse(element.Element(FOR_CLUB).Value),
            StartDateSale = DateTime.Parse(element.Element(START_DATE_SALE).Value),
            EndDateSale = DateTime.Parse(element.Element(END_DATE_SALE).Value)
        };
        return sale;
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        try
        {
            Console.WriteLine("read all-------------");
            XElement salesXml = XElement.Load(FILE_PATH);
            List<Sale> salesList = salesXml.Elements()
                .Where (e=> filter==null || filter( new Sale()
                {
                    ID = int.Parse(e.Element(ID).Value),
                    ProductId = int.Parse(e.Element(PRODUCT_ID).Value),
                    MinAmountForSale = int.Parse(e.Element(MIN_AMOUNT_FOR_SALE).Value),
                    SalePrice = int.Parse(e.Element(SALE_PRICE).Value),
                    ForClub = bool.Parse(e.Element(FOR_CLUB).Value),
                    StartDateSale = DateTime.Parse(e.Element(START_DATE_SALE).Value),
                    EndDateSale = DateTime.Parse(e.Element(END_DATE_SALE).Value)
                }))
                .Select(s => new Sale
                {
                    ID = int.Parse(s.Element(ID).Value),
                    ProductId = int.Parse(s.Element(PRODUCT_ID).Value),
                    MinAmountForSale = int.Parse(s.Element(MIN_AMOUNT_FOR_SALE).Value),
                    SalePrice = int.Parse(s.Element(SALE_PRICE).Value),
                    ForClub = bool.Parse(s.Element(FOR_CLUB).Value),
                    StartDateSale = DateTime.Parse(s.Element(START_DATE_SALE).Value),
                    EndDateSale = DateTime.Parse(s.Element(END_DATE_SALE).Value)
                }).ToList();
            Console.WriteLine("read all--222-----------");

            return salesList;
        }
        catch
        {
            throw new DalExceptionNoValuesByCondition("sale");

        }
    }

    public void Update(Sale item)
    {
        if (item == null)
            throw new DalExceptionNullReceived("sale");
        XElement salesXml = XElement.Load(FILE_PATH);
        var elementUpdate = salesXml.Elements(CLASS).FirstOrDefault(s => int.Parse(s.Element(ID).Value) == item.ID);
        if (elementUpdate == null)
            throw new DalExceptionIdDoesNotExistInTheList("sale");
        elementUpdate.Element(ID)?.SetValue(item.ID);
        elementUpdate.Element(PRODUCT_ID)?.SetValue(item.ProductId);
        elementUpdate.Element(MIN_AMOUNT_FOR_SALE)?.SetValue(item.MinAmountForSale);
        elementUpdate.Element(SALE_PRICE)?.SetValue(item.SalePrice);
        elementUpdate.Element(FOR_CLUB)?.SetValue(item.ForClub);
        elementUpdate.Element(START_DATE_SALE)?.SetValue(item.StartDateSale.ToString("yyyy-MM-dd"));
        elementUpdate.Element(END_DATE_SALE)?.SetValue(item.EndDateSale.ToString("yyyy-MM-dd"));

        salesXml.Save(FILE_PATH);
    }
}
