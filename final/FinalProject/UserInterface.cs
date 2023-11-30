public class UserInterface
{
    public List<Week> Calendar = new List<Week>();
    public List<Meal> mealOptions = new List<Meal>();

    public UserInterface()
    {
        Week defaultWeek = new Week();
        Calendar.Add(defaultWeek);
    }

    public void DisplayCalendar()
    {
        int i = 0;
        Console.WriteLine("Choose a week to view.");
        foreach (Week w in Calendar)
        {
            Console.WriteLine($"{i+1}. {w.weekName}");
            i++;
        }

        Console.Write("> ");
        int weekChoice = Int32.Parse(Console.ReadLine());

        if (weekChoice > Calendar.Count())
        {
            Console.WriteLine("Not a valid option.");
        }
        else
        {
            Calendar[weekChoice - 1].DisplayWeek();
        }
    }

    public void CreateMeal()
    {
        Console.Write("Please give the name of your dish: ");
        string name = Console.ReadLine();

        Console.WriteLine("\nPlease give the ingredients for the dish (Enter . when finished)");
        bool ingredientLoop = true;
        List<string> ingredients = new List<string>();
        do
        {
            Console.Write("> ");
            string ingredient = Console.ReadLine();
            if (ingredient != ".")
            {
                ingredients.Add(ingredient);
            }
            else
            {
                ingredientLoop = false;
            }
        } while (ingredientLoop == true);

        Meal meal = new Meal(name, ingredients);
        mealOptions.Add(meal);
    }
}