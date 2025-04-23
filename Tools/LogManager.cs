

namespace Tools;

public static class LogManager
{
    private const string BasePath = @"Log";

    public static string Tabs = "\t";
   
    private static string GerCurrentFolderPath()
    {
        return $@"{BasePath}\{DateTime.Now.Month.ToString()}";
    }

    private static string GetCurrentFilePath()
    {
        return @$"{GerCurrentFolderPath()}\{DateTime.Now.Day.ToString()}.txt";
    }

    public static void WriteToLog(string ProjectName, string FuncName , string Message)
    {  
        
        if(!Directory.Exists(GerCurrentFolderPath())) {
            Directory.CreateDirectory(GerCurrentFolderPath());
            
        }
        if (!File.Exists(GetCurrentFilePath()))
        {
            File.Create(GetCurrentFilePath()).Close();
            using (StreamWriter writer = new StreamWriter(GetCurrentFilePath(), true))
            {
                writer.WriteLine(DateTime.Now.Date);
            }
        }
        
        using(StreamWriter writer = new StreamWriter(GetCurrentFilePath(), true)) { 
            
            writer.WriteLine(Tabs+ DateTime.Now.TimeOfDay);
            writer.WriteLine($"\t {Tabs} {ProjectName}.{FuncName}");
            writer.WriteLine(Tabs+Message);
         
        }


    }
    public static void CleanLogFolder()
    {

        try
        {
            // קבלת כל התיקיות בתיקיה הנתונה
            string[] folders = Directory.GetDirectories(BasePath);
            int currentMonth = DateTime.Now.Month;

            foreach (string folder in folders)
            {
                // קבלת שם התיקיה
                string folderName = Path.GetFileName(folder);

                // המרת שם התיקיה למספר
                if (int.Parse(folderName) < (DateTime.Now.Month - 2 + 12) % 12) ;
                {
                    Directory.Delete(@$"{BasePath}/{folder}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(" שגיאה: " + ex.Message);
        }
    }


}
