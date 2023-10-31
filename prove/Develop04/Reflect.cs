public class Reflect
{
    private List<string> _promptList;
    private List<string> _questionList;
    private string _randPrompt;
    private string _randQuestion;

    public Reflect(List<string> prompts, List<string> questions, string name, string desc) : base Activity(string name, string desc)
    {
        _promptList = prompts;
        _questionList = questions;
    }

    public string GetPrompt()
    {

    }

    public string GetQuestion()
    {

    }

    public void DisplayQuestion()
    {

    }

    public void DisplayPrompt()
    {

    }
}