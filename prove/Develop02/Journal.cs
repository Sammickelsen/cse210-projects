public class Journal
{
    public List<Entry> JournalList = new List<Entry>();
    Entry newEntry = new Entry();

    public Journal()
    {

    }

    public void DisplayJournal()
    {
        foreach (Entry entry in JournalList)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveJournal(List<string> JournalList)
    {

    }

    public string LoadJournal()
    {
        return "hello";
    }

    public void AddEntry()
    {
        PromptGenerator newPrompt = new PromptGenerator();
        Console.WriteLine("Please respond to your prompt: ");
        newEntry.Prompt = newPrompt.GeneratePrompt();
        newEntry.DateTime = DateTime.Now.ToString("MM/dd/yyyy");
        Console.WriteLine(newEntry.Prompt);
        newEntry.Content = Console.ReadLine();
        JournalList.Add(newEntry);
    }

}