public class Day
{
    private string _dayName;
    private Breakfast _breakfast;
    private Lunch _lunch;
    private Dinner _dinner;

    
    public Day(string dayName)
    {
        _dayName = dayName;
    }

    public void DisplayDay()
    {
        Console.WriteLine($"{_dayName}: ");
        Console.Write($"   Breakfast: ");
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
}