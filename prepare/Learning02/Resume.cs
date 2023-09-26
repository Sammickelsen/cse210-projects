public class Resume
{
    // Member variables for the Resume class.
    public string _name = "";

    public List<Job> _jobs = new List<Job>();

    // Display the information saved under the Resume class.
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");
       
        foreach(Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
        
    }
}