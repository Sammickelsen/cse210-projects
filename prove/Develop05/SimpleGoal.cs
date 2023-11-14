public class SimpleGoal : Goal
{
    private bool _complete;

    public SimpleGoal(string description, string type = "SimpleGoal") : base(type, description)
    {
    }

    public override string IsComplete()
    {
        if (_complete == true)
        {
            return "{X}";
        }
        else
        {
            return "{ }";
        }
    }
}