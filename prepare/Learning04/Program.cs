using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment = new MathAssignment("Samuel Mickelsen", "Calculous", "7.3", "8-19");
        string summary = assignment.GetSummary();
        string homeworkList = assignment.GetHomeworkList();
        Console.WriteLine(summary);
        Console.WriteLine(homeworkList);

        Console.WriteLine();

        WritingAssignment english = new WritingAssignment("Samuel Mickelsen", "History", "Art through the Ages");
        string englishSummary = english.GetSummary();
        string writingInformation = english.GetWritingInformation();
        Console.WriteLine(englishSummary);
        Console.WriteLine(writingInformation);
    }
}