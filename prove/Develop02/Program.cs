using System;

class Program
{
    static void Main(string[] args)
    {
        bool resume = true;

        do
        {
            Console.WriteLine("Please choose an option below:");
            Console.WriteLine("1. Write an Entry");
            Console.WriteLine("2. Display the Journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. End");
            string choice = Console.ReadLine();

            

            if (choice == "1")
            {
                //Journal.AddEntry
            }
            else if (choice == "2")
            {
                //Journal.DisplayJournal
            }
            else if (choice == "3")
            {
                //Journal.SaveJournal
            }
            else if (choice == "4")
            {
                //Journal.LoadJournal
            }
            else if (choice == "5")
            {
                resume = false;
            }
        } while (resume == true);
    }
}