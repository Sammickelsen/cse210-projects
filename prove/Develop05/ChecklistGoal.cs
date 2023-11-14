public class ChecklistGoal : Goal
{
    private int _timesComplete;
    private int _maxComplete;

    public ChecklistGoal(string description, int maxComplete, string type = "ChecklistGoal") : base(type, description)
    {
        _maxComplete = maxComplete;
        _timesComplete = 0;
    }

    public override void IsComplete()
    {
        if (_timesComplete < _maxComplete)
        {
            Console.WriteLine($"{_timesComplete}/{_maxComplete}");
        }
        else
        {
            Console.WriteLine($"{_maxComplete}/{_maxComplete}");
        }
    }
}