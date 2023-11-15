public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string description, string name, string type = "SimpleGoal", int points = 100, bool isComplete = false) : base(type, description, name, points)
    {
        _isComplete = isComplete;
    }

    public override string IsComplete()
    {   
        if (_isComplete == false)
        {
            return "{ }";
        }
        else
        {
            return "{X}";
        }
        
    }

    public override void MarkDone()
    {
        _isComplete = true;
    }

    public override string GoaltoString()
    {
        return base.GoaltoString() + $"|{_isComplete}";
    }
}