using System;

class Program
{
    static void Main(string[] args)
    {
        // Create two instances of Job.
        Job job1 = new Job();
        Job job2 = new Job();
        job1._company = "Tesla";
        job1._jobTitle = "CEO";
        job1._startYear = 2015;
        job1._endYear = 2025;
        job2._company = "Meta";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2011;
        job2._endYear = 2018;

        // Create an instance of Resume.
        Resume myResume = new Resume();
        myResume._name = "John Doe";
        
        // Add job instances to the Resume jobs list.
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display name, and every job in list.
        myResume.DisplayResume();
        
    }
}