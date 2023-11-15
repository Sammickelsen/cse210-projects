using System;

class Program
{
    static void Main(string[] args)
    {
        UserInterface myUserInterface = new UserInterface();
        bool whileControl = true;

        do
        {
            Console.Clear();
            Console.WriteLine($"You have {myUserInterface.DisplayPoints()} points.\n");
            Console.Write("1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Update Goals \n6. End \n\n> ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {

            }
            else if (userInput == "2")
            {

            }
            else if (userInput == "3")
            {

            }
            else if (userInput == "4")
            {

            }
            else if(userInput == "5")
            {

            }
            else if (userInput == "6")
            {
                userInput = false;
            }

        } while (whileControl = true);

        myUserInterface.NewGoal();
        myUserInterface.NewGoal();
        myUserInterface.NewGoal();

        myUserInterface.DisplayGoals();
    }
}