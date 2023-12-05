using System.IO;

public class ReadWrite
{
    public ReadWrite()
    {
    }

    public void WriteFiles(List<Day> week)
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
    }

    public List<Day> ReadCalendar()
    {
        Console.Write("Please name the file you want to load to (Without .txt): ");
        string fileBase = Console.ReadLine();

        string[] calendarLines = System.IO.File.ReadAllLines(fileBase + "Calendar.txt");
        Week week = new Week();
        week.week.Clear();
        foreach (string line in calendarLines)
        {
            string[] parts = line.Split('|');
            string[] mealParts = parts[1].Split(',');

            Day day = new Day(parts[0]);
            if (mealParts[0] != null)
            {
                day.breakfast = mealParts[0];
            }
            else
            {
                day.breakfast = "";
            }
            if (mealParts[1] != null)
            {
                day.lunch = mealParts[1];
            }
            else
            {
                day.lunch = "";
            }
            if (mealParts[2] != null)
            {
                day.dinner = mealParts[2];
            }
            else
            {
                day.dinner = "";
            }
          
            week.week.Add(day);
        }
        return week.week;
    }

    public List<Meal> ReadBreakfast()
    {
        List<Meal> breakfasts = new List<Meal>();
        string[] lines = System.IO.File.ReadAllLines("MealsBreakfasts.txt");

        foreach(string line in lines)
        {
            string[] parts = line.Split("|");
            string name = parts[0];
            string type = parts[2];

            string[] ingredients = parts[1].Split(",");
            List<string> ingredientList = new List<string>();
            foreach (string item in ingredients)
            {
                ingredientList.Add(item);
            }
            
            Meal breakfast = new Meal(name, ingredientList, type);
            breakfasts.Add(breakfast);

        }

        return breakfasts;
    }

    public List<Meal> ReadLunch()
    {
        List<Meal> lunches = new List<Meal>();
        string[] lines = System.IO.File.ReadAllLines("MealsLunches.txt");

        foreach(string line in lines)
        {
            string[] parts = line.Split("|");
            string name = parts[0];
            string type = parts[2];

            string[] ingredients = parts[1].Split(",");
            List<string> ingredientList = new List<string>();
            foreach (string item in ingredients)
            {
                ingredientList.Add(item);
            }
            
            Meal lunch = new Meal(name, ingredientList, type);
            lunches.Add(lunch);

        }

        return lunches;
    }

    public List<Meal> ReadDinner()
    {
        List<Meal> dinners = new List<Meal>();
        string[] lines = System.IO.File.ReadAllLines("MealsDinners.txt");

        foreach(string line in lines)
        {
            string[] parts = line.Split("|");
            string name = parts[0];
            string type = parts[2];

            string[] ingredients = parts[1].Split(",");
            List<string> ingredientList = new List<string>();
            foreach (string item in ingredients)
            {
                ingredientList.Add(item);
            }
            
            Meal dinner = new Meal(name, ingredientList, type);
            dinners.Add(dinner);

        }

        return dinners;
    }
}