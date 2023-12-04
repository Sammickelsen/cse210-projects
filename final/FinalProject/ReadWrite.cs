using System.IO;

public class ReadWrite
{
    public ReadWrite()
    {
    }

    public void WriteFiles(List<Day> week, List<Meal> breakfasts, List<Meal> lunch, List<Meal> dinner)
    {
        Console.Write("Please name the file you want to save to (Without .txt): ");
        string fileBase = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileBase + "Calendar.txt"))
        {
            foreach (Day d in week)
            {
                string outPutString = $"{d.dayName}|{d.breakfast},{d.lunch},{d.dinner}";
                outputFile.WriteLine(outPutString);
            }
        }

        using (StreamWriter outputFile = new StreamWriter(fileBase + "Breakfasts.txt"))
        {
            foreach (Meal b in breakfasts)
            {
                string name = b.GetMealName();
                string type = b.GetMealType();
                string ingredients = b.DisplayIngredients();
                string outputString = $"{name}|{ingredients}|{type}";
                outputFile.WriteLine(outputString);
            }
        }

        using (StreamWriter outputFile = new StreamWriter(fileBase + "Lunches.txt"))
        {
            foreach (Meal l in lunch)
            {  
                string name = l.GetMealName();
                string type = l.GetMealType();
                string ingredients = l.DisplayIngredients();
                string outputString = $"{name}|{ingredients}|{type}";
                outputFile.WriteLine(outputString);
            }
        }

        using (StreamWriter outputFile = new StreamWriter(fileBase + "Dinners.txt"))
        {
            foreach (Meal d in dinner)
            {
                string name = d.GetMealName();
                string type = d.GetMealType();
                string ingredients = d.DisplayIngredients();
                string outputString = $"{name}|{ingredients}|{type}";
                outputFile.WriteLine(outputString);
            }
        }
    }

    public void ReadFiles()
    {
        Console.Write("Please name the file you want to load to (Without .txt): ");
        string fileBase = Console.ReadLine();

        string[] calendarLines = System.IO.File.ReadAllLines(fileBase + "Calendar.txt");
        string[] breakfastLines = System.IO.File.ReadAllLines(fileBase + "Breakfasts.txt");
        string[] lunchLines = System.IO.File.ReadAllLines(fileBase + "Lunches.txt");
        string[] dinnerLines = System.IO.File.ReadAllLines(fileBase + "Dinners.txt");
    }
}