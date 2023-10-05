using System.IO;

public class Journal
{
    // Created a list of Entry objects.
    public List<Entry> JournalList = new List<Entry>();
    

    public Journal()
    {

    }

    public void DisplayJournal()
    {
        // Loop through the journal and display each individual entry object.
        foreach (Entry entry in JournalList)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveJournal(List<Entry> JournalList)
    {
        // Save the journal object to a file called "myFile.txt"
        string fileName = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // Display an indicator that the file is saving to the user.
            Console.WriteLine("Saving to File...");

            // For every entry in the journal, save each property in the entry object
            // to a file.
            foreach (Entry e in JournalList)
            {
                outputFile.WriteLine($"{e.DateTime}|{e.Prompt}|{e.Content}");
            }

            // Display a save completed message to the user.
            Console.WriteLine("Save Complete!");
        }
    }

    public List<Entry> LoadJournal()
    {
        // Create an object to pull the newly loaded journal into.
        List<Entry> loadJournal = new List<Entry>();
        
        // Call the file that needs to be pulled from.
        string filename = "myFile.txt";

        // Use the .ReadAllLines functionality to read the file line
        // by line into an array
        string[] lines = System.IO.File.ReadAllLines(filename);

        // For each line in the new array, split them back into their
        // original properties and save them into the new journal list.
        foreach (string line in lines)
        {
            // Line looks like this: "{e.DateTime}|{e.Prompt}|{e.Content}"
            // Split them apart on the "|" and save in another array called parts.
            string[] parts = line.Split("|");
            // parts[0] - e.DateTime
            // parts[1] - e.Prompt
            // parts[2] - e.Content

            // Create a new entry object by placing the newly split properties
            //back in their original places.
            Entry newEntry = new Entry();
            newEntry.DateTime = parts[0];
            newEntry.Prompt = parts[1];
            newEntry.Content = parts[2];

            // Add new entry to the journal list.
            loadJournal.Add(newEntry);
        }

        return loadJournal;
    }

    public void AddEntry()
    {
        // Create new Entry object.
        Entry newEntry = new Entry();

        // Create a new prompt object in order to call the .GeneratePrompt
        // method later.
        PromptGenerator newPrompt = new PromptGenerator();

        // Display the random prompt from .GeneratePrompt to the user
        // and save the system's DateTime as a string.
        Console.WriteLine("Please respond to your prompt: ");
        newEntry.Prompt = newPrompt.GeneratePrompt();
        newEntry.DateTime = DateTime.Now.ToString("MM/dd/yyyy");
        Console.WriteLine(newEntry.Prompt);

        // Allow the user to input their response for the entry.
        newEntry.Content = Console.ReadLine();

        // Add the newly created Entry object to the Journal List.
        JournalList.Add(newEntry);
    }

}