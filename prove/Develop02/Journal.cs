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
                outputFile.WriteLine($"{e.DateTime}|{e.Prompt}|{e.Content}");
            }

            Console.WriteLine("Save Complete!");
        }
    }

    public List<Entry> LoadJournal()
    {
        List<Entry> loadJournal = new List<Entry>();
        string filename = "myFile.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            // Line looks like this: "{e.DateTime}|{e.Prompt}|{e.Content}"
            string[] parts = line.Split("|");

            // parts[0] - e.DateTime
            // parts[1] - e.Prompt
            // parts[2] - e.Content

            Entry newEntry = new Entry();
            newEntry.DateTime = parts[0];
            newEntry.Prompt = parts[1];
            newEntry.Prompt = parts[2];

            loadJournal.Add(newEntry);
        }

        return loadJournal;
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