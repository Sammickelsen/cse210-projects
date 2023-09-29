public class Resume
{
    // Member variables for the Resume class.
    public string Name = "";

    public List<Job> Jobs = new List<Job>();

    // Display the information saved under the Resume class.
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Jobs:");
       
        foreach(Job job in Jobs)
        {
            job.DisplayJobDetails();
        }
        
    }
}