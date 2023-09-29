public class Job
{
    // Member variables for the Job class.
    public string Company = "";
    public string JobTitle = "";
    public int StartYear = 0;
    public int EndYear = 0;

    public Job()
    {
    }

    public void DisplayJobDetails()
    {
        // Print job information to user.
        Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
    }


}