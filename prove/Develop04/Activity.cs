public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _activityDuration;
    public int Count;

    public Activity(string name, string desc)
    {
        _activityName = name;
        _activityDescription = desc;
    }

    public void EndMessage()
    {

    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session?");
        _activityDuration = Console.ReadLine();
    }

    public void Countdown(int count)
    {

    }
}