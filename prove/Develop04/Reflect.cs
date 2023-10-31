public class Reflect : Activity
{
    private string[] _promptList = {"Think about a time that you have helped someone.", "Think of a time you have felt happy."};
    private string[] _questionList  = {""};
    private string _randPrompt;
    private string _randQuestion;

    public Reflect(string[] prompts, string[] questions, string name, string desc) : base(name, desc)
    {
        _promptList = prompts;
        _questionList = questions;
    }

    public void GetPrompt()
    {
        Random rand = new Random();
        int randomInt = rand.Next(0, _promptList.Length);
        string prompt = _promptList[randomInt];
        _randPrompt = prompt;
    }

    public void GetQuestion()
    {
        Random rand = new Random();
        int randomInt = rand.Next(0, _questionList.Length);
        string question = _questionList[randomInt];
        _randQuestion = question;
    }

    public void DisplayQuestion()
    {
    }

    public void DisplayPrompt()
    {
    }
}