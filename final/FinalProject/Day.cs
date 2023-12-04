public class Day
{
    public string dayName;
    public string breakfast;
    public string lunch;
    public string dinner;

    
    public Day(string day)
    {
        dayName = day;
    }

    public void DisplayDay()
    {
        Console.WriteLine($"{dayName}: ");
        Console.Write($"   Breakfast: {breakfast}");
        Console.Write($"   Lunch: {lunch}");
        Console.Write($"   Dinner: {dinner}");
        Console.WriteLine();

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
                SetLunch(lunches[input - 1]);
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
                SetDinner(dinners[input - 1]);
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

    public void SetBreakfast(Meal bf)
    {
        breakfast = bf.GetName();
    }

    public void SetLunch(Meal lun)
    {
        lunch = lun.GetName();
    }

    public void SetDinner(Meal din)
    {
        dinner = din.GetName();
    }
}