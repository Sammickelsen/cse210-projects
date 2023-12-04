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
                string outputString = $"{b.DisplayMeal}|{b.DisplayIngredients}|{b.GetMealType}";
                
            }
        }

        using (StreamWriter outputFile = new StreamWriter(fileBase + "Lunches.txt"))
        {
            foreach (Meal l in lunch)
            {
                string outputString = $"{l.DisplayMeal}|{l.DisplayIngredients}|{l.GetMealType}";
                
            }
        }

        using (StreamWriter outputFile = new StreamWriter(fileBase + "Dinners.txt"))
        {
            foreach (Meal d in dinner)
            {
                string outputString = $"{d.DisplayMeal}|{d.DisplayIngredients}|{d.GetMealType}";
                
            }
        }
    }

    public void ReadFiles()
    {

    }
}