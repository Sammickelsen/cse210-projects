using System;

class Program
{
    static void Main(string[] args)
    {
        ReadWrite readWrite = new ReadWrite();
        UserInterface myUserInterface = new UserInterface();
        bool whileControl = true;

        while (whileControl == true)
        {
            Console.Clear();
            Console.WriteLine($"You have {myUserInterface.totalPoints} points.\n");
            Console.Write("1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Update Goals \n6. End \n\n> ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.Clear();
                myUserInterface.NewGoal();
            }
            else if (userInput == "2")
            {
                Console.Clear();
                myUserInterface.DisplayGoals();
                Console.Write("\nClick enter when you are done.\n> ");
                Console.ReadLine();
            }
            else if (userInput == "3")
            {
                Console.Clear();
                Console.Write("Please name the file you would like to save: ");
                string fileName = Console.ReadLine() + ".txt";
                readWrite.WriteFiles(myUserInterface.GoalList, myUserInterface.totalPoints, fileName);
            }
            else if (userInput == "4")
            {
                Console.Clear();
                Console.Write("Please give the file you would like to read: ");
                string fileName = Console.ReadLine() +".txt";
                myUserInterface.GoalList = readWrite.ReadGoals(fileName);
                myUserInterface.totalPoints = readWrite.ReadPoints(fileName);
            }
            else if(userInput == "5")
            {
                Console.WriteLine("Updating...");
            }
            else if (userInput == "6")
            {
                whileControl = false;
            }

        }
    }
}