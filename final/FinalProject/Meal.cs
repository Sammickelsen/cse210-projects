public class Meal
{
    private string _mealName;
    private List<string> _ingredients = new List<string>();


    public Meal(string mealName, List<string> ingredients)
    {
        _mealName = mealName;
        _ingredients = ingredients;
    }

    public virtual void AddMeal()
    {

    }

    public void DisplayMeal()
    {

    }
}