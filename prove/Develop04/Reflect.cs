public class Reflect : Activity
{
    private List<string> _promptList;
    private List<string> _questionList;
    private string _randPrompt;
    private string _randQuestion;

    public Reflect(List<string> prompts, List<string> questions, string name, string desc) : base(name, desc)
    {
        _promptList = prompts;
        _questionList = questions;
    }

    public string GetPrompt()
    {
        return string prompt;
    }

    public string GetQuestion()
    {
        return string question;
    }

    public void DisplayQuestion()
    {
    }

    public void DisplayPrompt()
    {
    }
}