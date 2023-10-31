public class Listing : Activity
{
    private string _prompt;
    private List<string> _prompts;
    private List<string> _userList;

    public Listing(string name = "Listing", string desc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") : base(name, desc)
    {
 
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