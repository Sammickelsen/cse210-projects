public class Reflect : Activity
{
    private string[] _promptList = {"Think about a time that you have helped someone.", "Think of a time you have felt happy."};
    private string[] _questionList  = {""};
    private string _randPrompt;
    private string _randQuestion;

    public Reflect(string name = "Reflect", string desc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") : base(name, desc)
    {

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