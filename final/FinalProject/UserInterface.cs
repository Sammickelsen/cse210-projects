public class UserInterface
{
    public List<Week> Calendar = new List<Week>();
    public List<Meal> breakfastOptions = new List<Meal>();
    public List<Meal> lunchOptions = new List<Meal>();
    public List<Meal> dinnerOptions = new List<Meal>();

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

        bool controlLoop = true;
        do
        {
            Console.WriteLine("Please choose which meal this dish would fit under: ");
            Console. Write("1. Breakfast \n2. Lunch \n3. Dinner \n> ");
            string type = Console.ReadLine();

            if (type == "1")
            {
                Meal meal = new Meal(name, ingredients, "breakFast");
                breakfastOptions.Add(meal);
                controlLoop = false;
            }
            else if (type == "2")
            {
                Meal meal = new Meal(name, ingredients, "lunch");
                lunchOptions.Add(meal);
                controlLoop = false;
            }
            else if (type == "3")
            {
                Meal meal = new Meal(name, ingredients, "dinner");
                dinnerOptions.Add(meal);
                controlLoop = false;
            }
            else
            {
                Console.WriteLine("Please choose a valid answer.");
            }
        } while (controlLoop == true); 
    }

    public void PlanCalendar()
    {
        Console.WriteLine("Choose a week to edit.");
        int i = 0;
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
            Calendar[weekChoice - 1].PlanWeek(breakfastOptions, lunchOptions, dinnerOptions);
        }
    }
}