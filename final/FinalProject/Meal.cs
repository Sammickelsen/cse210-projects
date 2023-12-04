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

    public string DisplayIngredients()
    {
        string ingredients = "";
        foreach (String ing in _ingredients)
        {
            ingredients += $",{ing}";
        }
        return ingredients;
    }

    public string GetMealType()
    {
        return _mealType;
    }
}