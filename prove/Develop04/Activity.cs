public class Activity
{
    private string _activityName;
    private string _activityDescription;
    protected int _activityDuration;
    public int Count;

    public Activity(string name, string desc)
    {
        _activityName = name;
        _activityDescription = desc;
    }

    public void EndMessage()
    {
        Thread.Sleep(1000);
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        Console.WriteLine();
        Thread.Sleep(1000);
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_activityName} Activity.");
        Thread.Sleep(2000);
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity");
        Console.WriteLine();

        Console.WriteLine(_activityDescription);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        string userInput = Console.ReadLine();
        _activityDuration = int.Parse(userInput);
        Console.WriteLine();
    }

    public void LoadingAnimation()
    {
        for (int i = 0; i < 6; i++) 
        {
            Console.Write("|");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(100);
            Console.Write("\b \b");
        }
    }
}