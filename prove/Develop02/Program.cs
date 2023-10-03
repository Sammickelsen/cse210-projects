using System;

class Program
{
    static void Main(string[] args)
    {
        bool resume = true;
        Journal myJournal = new Journal();
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
                myJournal.AddEntry();
            }
            else if (choice == "2")
            {
                myJournal.DisplayJournal();
            }
            else if (choice == "3")
            {
                myJournal.SaveJournal(myJournal.JournalList);
            }
            else if (choice == "4")
            {
                myJournal.JournalList = myJournal.LoadJournal();
            }
            else if (choice == "5")
            {
                resume = false;
            }
            else
            {
                Console.WriteLine("Please input a valid option. (1-5)");
            }
        } while (resume == true);
    }
}