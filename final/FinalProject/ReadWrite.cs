using System.IO;

public class ReadWrite
{
    public ReadWrite()
    {
    }

    public void WriteFiles(List<Day> week, List<Breakfast> breakfasts, List<Lunch> lunch, List<Dinner> dinner)
    {
        Console.Write("Please name the file you want to save to (Without .txt): ");
        string fileBase = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileBase + "Calendar.txt"))
        {
            foreach (Day d in week)
            {
                string outPutString = $"{d.dayName}|{d.GetBreakfast},{d.GetLunch},{d.GetDinner}";
            }
        }


    }

    public void ReadFiles()
    {

    }
}