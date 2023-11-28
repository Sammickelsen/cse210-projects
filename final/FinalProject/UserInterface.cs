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
        Console.WriteLine($"Breakfast: ");
        GetBreakfast();
        Console.WriteLine("Lunch: ");
        GetLunch();
        Console.WriteLine("Dinner: ");
        GetDinner();
        Console.WriteLine();

    }

    public void GetBreakfast()
    {
        _breakfast.DisplayMeal();
    }

    public void GetLunch()
    {
        _lunch.DisplayMeal();
    }

    public void GetDinner()
    {
        _dinner.DisplayMeal();
    }
}