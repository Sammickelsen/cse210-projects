using System;

class Program
{
    static void Main(string[] args)
    {
        UserInterface userInterface = new UserInterface();
        ReadWrite readWrite = new ReadWrite();
        bool loopControl = true;

        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Meal Planner! \n\nWhat would you like to do?\n");
            Console.Write("1. Display Calendar \n2. Create New Meal \n3. Plan Week \n4. Save Plan \n5. Load Plan \n6. Exit \n> ");

            string choice = Console.ReadLine();
            // Display Calendar
            if (choice == "1")
            {
                userInterface.DisplayCalendar();
                Console.WriteLine("Press Enter to Continue");
                Console.ReadLine();
            }
            // Create a new meal
            else if (choice == "2")
            {
                userInterface.CreateMeal();
            }
            // Plan meals for the week
            else if (choice == "3")
            {
                userInterface.PlanCalendar();
            }
            // Save current plan to file
            else if (choice == "4")
            {
                readWrite.WriteFiles(userInterface.Calendar[0].week, userInterface.breakfastOptions, userInterface.lunchOptions, userInterface.dinnerOptions);
            }
            // Load plan from a file
            else if (choice == "5")
            {

            }
            // Exit program
            else if(choice == "6")
            {
                loopControl = false;
            }
            else
            {
                Console.WriteLine("Please input a valid response. (1-6)");
            }
        } while (loopControl == true);
    }
}