public class EternalGoal : Goal
{

    public EternalGoal(string description, string name, string type = "EternalGoal", int points = 50) : base(type, description, name, points)
    { 
    }

    public override string IsComplete()
    {
        return "{ }";
    }

    public override void MarkDone()
    {
    }
}