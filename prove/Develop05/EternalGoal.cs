public class EternalGoal : Goal
{
    private bool _onceComplete;

    public EternalGoal(string description, string type = "EternalGoal") : base(type, description)
    { 
    }

    public override string IsComplete()
    {
        if (_onceComplete == true)
        {
            return "{X}";
        }
        else
        {
            return "{ }";
        }
    }
}