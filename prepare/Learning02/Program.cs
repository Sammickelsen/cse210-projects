using System;

class Program
{
    static void Main(string[] args)
    {
        // Create two instances of Job.
        Job job1 = new Job();
        Job job2 = new Job();
        job1.Company = "Tesla";
        job1.JobTitle = "CEO";
        job1.StartYear = 2015;
        job1.EndYear = 2025;
        job2.Company = "Meta";
        job2.JobTitle = "Software Engineer";
        job2.StartYear = 2011;
        job2.EndYear = 2018;

        // Create an instance of Resume.
        Resume myResume = new Resume();
        myResume.Name = "John Doe";
        
        // Add job instances to the Resume jobs list.
        myResume.Jobs.Add(job1);
        myResume.Jobs.Add(job2);

        // Display name, and every job in list.
        myResume.DisplayResume();
        
    }
}