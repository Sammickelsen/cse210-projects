public class Goal
{
    protected int _points;
    protected string _goalDescription;
    private string _goalType;
    private string _goalName;

    public Goal(string type, string description, string name, int points)
    {
        _goalType = type;
        _goalDescription = description;
        _points = points;
        _goalName = name;
    }

    public virtual string IsComplete()
    {
        return "";
    }
    
    public virtual void DisplayGoal()
    {
        Console.WriteLine($"{_goalName} ({_goalDescription}) {IsComplete()}");
    }

    public virtual void MarkDone()
    {
    }
    
    public virtual string GoaltoString()
    {
        string goalString = $"{_goalType}:{_goalName}|{_goalDescription}|{_points}";
        return goalString;
    }

    public string GetName()
    {
        return _goalName;
    }

    public virtual int UpdatePoints()
    {
        return _points;
    }
}