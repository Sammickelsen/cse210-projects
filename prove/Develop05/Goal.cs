public class Goal
{
    private int _points;
    protected string _goalDescription;
    private string _goalType;

    public Goal(string type, string description)
    {
        _goalType = type;
        _goalDescription = description;
    }

    public void RecordEvent()
    {

    }

    public virtual string IsComplete()
    {
        return "";
    }
    
    public virtual void DisplayGoal()
    {
        Console.WriteLine($"{_goalDescription} {IsComplete()}");
    }
}