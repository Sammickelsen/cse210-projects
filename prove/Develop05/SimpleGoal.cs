public class SimpleGoal : Goal
{
    private int _timesCompleted;

    public SimpleGoal(string description, string type = "SimpleGoal") : base(type, description)
    {
        _timesCompleted = 0;
    }

    public override string IsComplete()
    {
        return $"{_timesCompleted}";
    }

    public override void MarkDone()
    {
        _timesCompleted += 1;
    }
}