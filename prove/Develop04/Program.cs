using System;

class Program
{
    static void Main(string[] args)
    {
        bool loopControl = true;

        Breathe breatheActivity = new Breathe();
        Listing listingActivity = new Listing();
        Reflect reflectActivity = new Reflect();

        while (loopControl == true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string response = Console.ReadLine();

            if (response == "1")
            {
                breatheActivity.StartMessage();
                breatheActivity.EndMessage();
            }
            else if (response == "2")
            {
                reflectActivity.StartMessage();
                reflectActivity.EndMessage();
            }
            else if (response == "3")
            {
                listingActivity.StartMessage();
                listingActivity.EndMessage();
            }
            else if (response == "4")
            {
                Console.WriteLine("Quitting...");
                loopControl = false;
            }
            else
            {
                Console.WriteLine("Please input a valid answer (1-4)");
            }
        }
    }
}