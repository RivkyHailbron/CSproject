
namespace BO;

//חריגה עבור מזהה שלא קיים
[Serializable]
public class BLExceptionIdDoesNotExistInTheList : Exception
{

    public BLExceptionIdDoesNotExistInTheList(string type) : base(type) { }
    public BLExceptionIdDoesNotExistInTheList(string type,Exception innerException) : base(type, innerException) { }
   
}
//חריגה עבור ישות עם מספר מזהה שכבר קיים ברשימה
[Serializable]
public class BLExceptionIdIsAlreadyExistInTheList : Exception
{

    public BLExceptionIdIsAlreadyExistInTheList(string type) : base(type) { }
    
    public BLExceptionIdIsAlreadyExistInTheList(string type, Exception innerException) : base(type, innerException) { }
   
}
//Nullחריגה עבור קבלת ישות

[Serializable]
public class BLExceptionNullReceived : Exception
{
    public BLExceptionNullReceived(string type) : base(type) { }  
    public BLExceptionNullReceived(string type, Exception innerException) : base(type, innerException) { }
}
// חריגה עבור תנאי שאין ערכים העונים על תנאי זה

[Serializable]
public class BlExceptionNoValuesByCondition : Exception
{
    public BlExceptionNoValuesByCondition(string type):base(type) { }
    public BlExceptionNoValuesByCondition(string type, Exception innerException) : base(type, innerException) { }


}

//חריגה עבור בקשה להזמנת כמות שאין מספיק במלאי ממוצר מסויים
[Serializable]
public class BLExceptionNotEnoughInStock : Exception
{
    public BLExceptionNotEnoughInStock(string type)
    {
        throw new Exception($"Not enough in stock for {type}");
    }
    public BLExceptionNotEnoughInStock(string type, Exception innerException) : base($"Not enough in stock for {type}", innerException) { }
}

// שגיאה בקריאת קובץ XML

[Serializable]
public class BlExceptionErrorInReadFromXml : Exception
{
    public BlExceptionErrorInReadFromXml(string type) : base(type) { }
    public BlExceptionErrorInReadFromXml(string type, Exception innerException) : base(type, innerException) { }
}

// שגיאה בכתיבה לקובץ XML

[Serializable]
public class BlExceptionErrorInWriteToXml : Exception
{
    public BlExceptionErrorInWriteToXml(string type) : base(type) { }
    public BlExceptionErrorInWriteToXml(string type, Exception innerException) : base(type, innerException) { }
}




