public class ChecklistGoal : Goal
{
    private int _timesComplete;
    private int _maxComplete;

    private int _finishedPoints;

    public ChecklistGoal(string description, string name, int maxComplete, int timesComplete = 0, string type = "ChecklistGoal", int points = 50, int finished = 500) : base(type, description, name, points)
    {
        _maxComplete = maxComplete;
        _timesComplete = timesComplete;
    }

    public override string IsComplete()
    {
        if (_timesComplete < _maxComplete)
        {
            return $"{_timesComplete}/{_maxComplete}";
        }
        else
        {
            return $"{_maxComplete}/{_maxComplete}";
        }
    }

    public override void MarkDone()
    {
        if (_timesComplete < _maxComplete)
        {
            _timesComplete += 1;
        }
    }

    public override string GoaltoString()
    {
        return base.GoaltoString() + $"|{_finishedPoints}|{_timesComplete}|{_maxComplete}";
    }
}