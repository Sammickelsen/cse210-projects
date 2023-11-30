public class Dinner : Meal
{
    public Dinner(string mealName, List<string> ingredients, string mealType) : base(mealName, ingredients, mealType)
    {

    }

    public override void AddMeal()
    {
        base.AddMeal();
    }
}