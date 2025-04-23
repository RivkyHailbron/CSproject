

using DO;

namespace Dal;

internal static class DataSource
{
    internal static List<Product?> Products = new List<Product?>();
    internal static List<Customer?> Customers = new List<Customer?>();
    internal static List<Sale?> Sales = new List<Sale?>();

    internal static class Config
    {
        //שדה מספרי קבוע (const) בהרשאת internal, שיקבל ערך התחלתי למספר הרץ: המספר המזהה הקטן ביותר לפי דרישת כל ישות.
        internal const int StartValproduct = 0;
        internal const int StartValSale = 100;

        //שדה מספרי סטטי בהרשאת private שיקבל כערך התחלתי את השדה הקבוע הקודם.
        private static int PrevValproduct = StartValproduct;
        private static int PrevValSale = StartValSale;

        //מאפיין עם get בלבד שיחזיר את ערך השדה הסטטי ויקדם אותו אוטומטית.
        public static int GetValProduct
        {
            get
            {
                PrevValproduct++;
                return PrevValproduct;
            }
        }

        public static int GetValSale
        {
            get
            {
                PrevValSale++;
                return PrevValSale;
            }
        }

    }
}
