using System.IO;

public class Journal
{
    public List<Entry> JournalList = new List<Entry>();
    

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

    public void SaveJournal(List<Entry> JournalList)
    {
        string fileName = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            Console.WriteLine("Saving to File...");

            foreach (Entry e in JournalList)
            {
                outputFile.WriteLine(e.DateTime);
                outputFile.WriteLine(e.Prompt);
                outputFile.WriteLine(e.Content);
            }

            Console.WriteLine("Save Complete!");
        }
    }

    public List<Entry> LoadJournal()
    {
        return JournalList;
    }

    public void AddEntry()
    {
        Entry newEntry = new Entry();
        PromptGenerator newPrompt = new PromptGenerator();
        Console.WriteLine("Please respond to your prompt: ");
        newEntry.Prompt = newPrompt.GeneratePrompt();
        newEntry.DateTime = DateTime.Now.ToString("MM/dd/yyyy");
        Console.WriteLine(newEntry.Prompt);
        newEntry.Content = Console.ReadLine();
        JournalList.Add(newEntry);
    }

}