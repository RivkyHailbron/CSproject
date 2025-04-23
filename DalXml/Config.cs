
using System;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Dal;

internal static class Config
{
    private static string xmlName = "../xml/data-config.xml";
    private static int readFromConfig(string name)
    {
        //קבלת רשימת הלקוחות מהXML
        XElement config = XElement.Load(xmlName);
        int val;
        if (!int.TryParse(config.Element(name).Value, out val))
        {
            throw new Exception("לא נמצא בקונפיג");
        }
        return val;
    }
    private static int readFromConfigAndIncrease(string name)
    {
        //קבלת רשימת הלקוחות מהXML
        XElement config = XElement.Load(xmlName);
        XElement element = config.Element(name);
        int val;
        if (!int.TryParse(element.Value, out val))
        {
            throw new Exception("לא נמצא בקונפיג");
        }
        element.SetValue(val + 1);
        config.Save(xmlName);
        return val;
    }

    private static int startValproduct = readFromConfig("startValproduct");
    private static int startValSale = readFromConfig("startValSale");

    public static int NextValProduct
    {

        get
        {
            return startValproduct + readFromConfigAndIncrease("NextValProduct");
        }

    }
    public static int NextValSale
    {

        get
        {
            return startValSale + readFromConfigAndIncrease("NextValSale");
        }

    }


}
