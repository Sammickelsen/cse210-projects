public class Day
{
    public string dayName;
    private Meal _breakfast;
    private Meal _lunch;
    private Meal _dinner;

    
    public Day(string day)
    {
        dayName = day;
    }

    public void DisplayDay()
    {
        Console.WriteLine($"{dayName}: ");
        Console.Write("   Breakfast: ");
        GetBreakfast();
        Console.Write("   Lunch: ");
        GetLunch();
        Console.Write("   Dinner: ");
        GetDinner();
        Console.WriteLine();

    }

    public void GetBreakfast()
    {   if (_breakfast != null)
        {
            _breakfast.DisplayMeal();
        }
        else
        {
            Console.WriteLine("Not assigned");
        }
    }

    public void GetLunch()
    {
        if (_lunch != null)
        {
            _lunch.DisplayMeal();
        }
        else
        {
            Console.WriteLine("Not assigned");
        }
    }

    public void GetDinner()
    {
        if (_dinner != null)
        {
            _dinner.DisplayMeal();
        }
        else
        {
            Console.WriteLine("Not assigned");
        }
    }

    public void PlanDay(List<Meal> breakfasts, List<Meal> lunches, List<Meal> dinners)
    {   
        bool planning = true;
        do
        {Console.WriteLine("What meal would you like to add?\n");
        Console.WriteLine("1. Breakfast \n2. Lunch \n3. Dinner \n4.Back to Week");
        
        Console.Write("\n> ");
        string userInput = Console.ReadLine();

        if (userInput == "1")
        {
            Console.WriteLine("Please choose a meal to add:");
            int i = 1;
            foreach (Meal breakfast in breakfasts)
            {
                Console.WriteLine($"{i}. {breakfast.GetName()}");
                i++;
            }

            Console.Write("\n> ");
            int input = Int32.Parse(Console.ReadLine());

            if (input < breakfasts.Count + 1)
            {
                SetBreakfast(breakfasts[input - 1]);
            }
        }
        else if (userInput == "2")
        {
            Console.WriteLine("Please choose a meal to add:");
            int i = 1;
            foreach (Meal lunch in lunches)
            {
                Console.WriteLine($"{i}. {lunch.GetName()}");
                i++;
            }

            Console.Write("\n> ");
            int input = Int32.Parse(Console.ReadLine());

            if (input < lunches.Count + 1)
            {
                SetBreakfast(lunches[input - 1]);
            }
        }
        else if (userInput == "3")
        {
            Console.WriteLine("Please choose a meal to add:");
            int i = 1;
            foreach (Meal dinner in dinners)
            {
                Console.WriteLine($"{i}. {dinner.GetName()}");
                i++;
            }

            Console.Write("\n> ");
            int input = Int32.Parse(Console.ReadLine());

            if (input < dinners.Count + 1)
            {
                SetBreakfast(dinners[input - 1]);
            }
        }
        else if (userInput == "4")
        {
            planning = false;
        }
        else
        {
            Console.WriteLine("Please choose a valid option. (1-4)");
        }
        } while (planning == true);



    }

    public void SetBreakfast(Meal breakfast)
    {
        _breakfast = breakfast;
    }

    public void SetLunch(Meal lunch)
    {
        _lunch = lunch;
    }

    public void SetDinner(Meal dinner)
    {
        _dinner = dinner;
    }
}