public class Goal
{
    private int _points;
    private string _goalDescription;
    private string _goalName;

    public Goal(string name, string description)
    {
        _goalName = name;
        _goalDescription = description;
    }

    public void RecordEvent()
    {

    }

    public virtual void IsComplete()
    {

    }
}