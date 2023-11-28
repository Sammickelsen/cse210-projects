public class Meal
{
    private string _mealName;
    private List<string> _ingredients = new List<string>();
    private string _mealType;


    public Meal(string mealName, List<string> ingredients, string mealType)
    {
        _mealName = mealName;
        _ingredients = ingredients;
        _mealType = mealType;
    }

    public virtual void AddMeal()
    {

    }

    public void DisplayMeal()
    {
        
    }
}