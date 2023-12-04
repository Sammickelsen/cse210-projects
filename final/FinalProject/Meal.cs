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

    public string GetMealName()
    {
        return _mealName;
    }

    public string DisplayIngredients()
    {
        string ingredients = "";
        foreach (string ing in _ingredients)
        {
            ingredients += $"{ing},";
        }
        Console.WriteLine(ingredients);
        return ingredients;
    }

    public string GetMealType()
    {
        return _mealType;
    }
}