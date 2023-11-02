public class Breathe : Activity
{
    public Breathe(string name = "Breathe", string desc = "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.") : base(name, desc)
    {

    }

    public void InOutLoop()
    {   
        Console.Clear();
        StartMessage();

        Console.Clear();
        Console.WriteLine("Get ready...");
        LoadingAnimation();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_activityDuration);

        while (startTime < futureTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.WriteLine("\b \b");
            Console.Write("Now breathe out...3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine();
            startTime = DateTime.Now;
        }

        EndMessage();
    }
}