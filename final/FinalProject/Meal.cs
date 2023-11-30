public class Meal
{
    private string _mealName;
    private List<string> _ingredients = new List<string>();
    private string _mealType;

    public Meal(string mealName, List<string> ingredients, string mealType)
    {
        _mealType = mealType;
        _mealName = mealName;
        _ingredients = ingredients;
    }

    public virtual void AddMeal()
    {

    }

    public string GetName()
    {
        return _mealName;
    }

    public void DisplayMeal()
    {
        Console.WriteLine($"{_mealName}");
    }
}