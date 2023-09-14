using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for a grade percentage
        Console.Write("Please give your grade percentage for the class: ");
        string textValue = Console.ReadLine();
        int score = int.Parse(textValue);

        // Compare percentage to letter grades
        string letter;

        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine(letter);

        if (score >= 70)
        {
            Console.WriteLine("Congradulations on passing the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you failed the class...");
        }

        
    }
}