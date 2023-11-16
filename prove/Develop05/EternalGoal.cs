public class EternalGoal : Goal
{

    public EternalGoal(string description, string name, string type = "EternalGoal", int points = 50) : base(type, description, name, points)
    { 
    }

    public override string IsComplete()
    {
        return "{ }";
    }

    public override int UpdatePoints()
    {
        Console.WriteLine("Congradulations! You completed your goal!");
        Console.WriteLine($"You got {_points} points!");
        return base.UpdatePoints();
    }
}