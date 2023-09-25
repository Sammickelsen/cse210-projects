using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Tesla";

        Console.WriteLine(job1._company);
    }
}