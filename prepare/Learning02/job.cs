public class Job
{
    // Member variables for the Job class.
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    public Job()
    {
    }

    public void DisplayJobDetails()
    {
        // Print job information to user.
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }


}