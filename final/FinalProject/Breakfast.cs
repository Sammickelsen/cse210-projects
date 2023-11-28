public class Breakfast : Meal
{
    public Breakfast(string mealName, List<string> ingredients, string mealType): base(mealName, ingredients, mealType)
    {

    }

    public override void AddMeal()
    {
        base.AddMeal();
    }
}