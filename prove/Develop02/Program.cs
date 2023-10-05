using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a bool to allow for a while loop, created a Journal object.
        bool resume = true;
        Journal myJournal = new Journal();

        // Loop through the menu until the user quits out of the program.
        do
        {
            Console.WriteLine("Please choose an option below:");
            Console.WriteLine("1. Write an Entry");
            Console.WriteLine("2. Display the Journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. End");
            string choice = Console.ReadLine();
            Console.WriteLine("");

            

            if (choice == "1")
            {
                // Call the AddEntry Method
                // Allows the user to add a written entry to the journal.
                myJournal.AddEntry();
                Console.WriteLine("");
            }
            else if (choice == "2")
            {
                // Call the DisplayJournal Method
                // Displays all previous entries to the user.
                myJournal.DisplayJournal();
                Console.WriteLine("");
            }
            else if (choice == "3")
            {
                // Call the SaveJournal method
                myJournal.SaveJournal(myJournal.JournalList);
                Console.WriteLine("");
            }
            else if (choice == "4")
            {
                // Call the LoadJournal Method and replace myJournal
                // with the loaded journal.
                myJournal.JournalList = myJournal.LoadJournal();
                Console.WriteLine("");
            }
            else if (choice == "5")
            {
                // Quit the program.
                resume = false;
            }
            else
            {
                // An else case to cover any inputs outside of the intended ones.
                Console.WriteLine("Please input a valid option. (1-5)");
            }
        } while (resume == true);
    }
}