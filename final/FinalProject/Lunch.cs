public class Lunch : Meal
{
    public Lunch(string mealName, List<string> ingredients, string mealType) : base(mealName, ingredients, mealType)
    {

    }

    public override void AddMeal()
    {
        base.AddMeal();
    }
}