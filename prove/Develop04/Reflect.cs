public class Reflect : Activity
{
    private string[] _promptList = {"Think of a time when you stood up for someone else.",
     "Think of a time when you did something really difficult.",
     "Think of a time when you helped someone in need.",
      "Think of a time when you did something truly selfless."};
    private string[] _questionList  = {"Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"};
    private string _randPrompt;
    private string _randQuestion;

    public Reflect(string name = "Reflect", string desc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") : base(name, desc)
    {

    }

    public string GetPrompt()
    {
        Random rand = new Random();
        int randomInt = rand.Next(0, _promptList.Length);
        string prompt = _promptList[randomInt];
        return prompt;
    }

    public string GetQuestion()
    {
        Random rand = new Random();
        int randomInt = rand.Next(0, _questionList.Length);
        string question = _questionList[randomInt];
        return question;
    }

    public void DisplayQuestion()
    {
        Console.WriteLine(GetQuestion());
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine(GetPrompt());
    }

    public void ReflectLoop()
    {
        Console.WriteLine("Get ready...");
        LoadingAnimation();

        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("Please press any key when you have something in mind. ");
        Console.ReadLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_activityDuration);

        while (startTime < futureTime)
        {
            Console.WriteLine();
            DisplayQuestion();
            LoadingAnimation(10);
            startTime = DateTime.Now;
        }
    }
}