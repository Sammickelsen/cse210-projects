public class Listing : Activity
{
    private string _prompt;
    private List<string> _prompts;
    private List<string> _userList;

    public Listing(List<string> prompts, string name, string desc) : base(name, desc)
    {
        _prompts = prompts;
    }

    public string GetPrompt()
    {
        string prompt = "";
        return prompt;
    }

    public void DisplayPrompt()
    {
    }

    public string RecordListing()
    {
        string listing = "";
        return listing;
    }

    public void DisplayList()
    {

    }
}