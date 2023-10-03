public class Entry
{
    public string DateTime { get; set; }

    public string Prompt { get; set; }

    public string Content { get; set; }

    public Entry()
    {
    }

    public void DisplayEntry()
    {
        Console.WriteLine(DateTime);
        Console.WriteLine(Prompt);
        Console.WriteLine(Content);
    }

}