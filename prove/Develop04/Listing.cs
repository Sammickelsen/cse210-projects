public class Listing : Activity
{
    private string _prompt;
    private string[] _prompts = {"Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"};
    private List<string> _userList;

    public Listing(string name = "Listing", string desc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") : base(name, desc)
    {
 
    }

    public void GetPrompt()
    {
        Random rand = new Random();
        int randomInt = rand.Next(0, _prompts.Length);
        string prompt = _prompts[randomInt];
        _prompt = prompt;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine(_prompt);
    }

    public void RecordListing()
    {
        Console.Write("> ");
        string response = Console.ReadLine();
        _userList.Add(response);
    }

    public void DisplayList()
    {
        Console.WriteLine($"You listed {_userList.Count} items!");
    }
}