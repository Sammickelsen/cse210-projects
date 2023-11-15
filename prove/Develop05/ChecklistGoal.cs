public class ChecklistGoal : Goal
{
    private int _timesComplete;
    private int _maxComplete;

    public ChecklistGoal(string description, int maxComplete, string type = "ChecklistGoal") : base(type, description)
    {
        _maxComplete = maxComplete;
        _timesComplete = 0;
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

    public override void DisplayGoal()
    {
        Console.WriteLine($"{_goalDescription} {IsComplete()}");
    }

    public override void MarkDone()
    {
        if (_timesComplete < _maxComplete)
        {
            _timesComplete += 1;
        }
    }
}