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
        Console.WriteLine("Well Done!");
        Consoel.WriteLine();
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_activityName} Activity.");
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
        Console.WriteLine();
    }

    public void Countdown()
    {
        
    }
}