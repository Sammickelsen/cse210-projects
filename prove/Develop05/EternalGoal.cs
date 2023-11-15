public class EternalGoal : Goal
{
    private bool _onceComplete;

    public EternalGoal(string description, string type = "EternalGoal", bool complete = false) : base(type, description)
    { 
        _onceComplete = complete;
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

    public override void MarkDone()
    {
        _onceComplete = true;
    }
}