using System;

class Program
{
    static void Main(string[] args)
    {
        bool loopControl = true;

        while (loopControl == true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string response = Console.ReadLine();

            if (response == "1")
            {
                Breathe breatheActivity = new Breathe();
                breatheActivity.StartMessage();
                breatheActivity.InOutLoop();
                breatheActivity.EndMessage();
            }
            else if (response == "2")
            {
                Reflect reflectActivity = new Reflect();
                reflectActivity.StartMessage();
                reflectActivity.EndMessage();
            }
            else if (response == "3")
            {
                Listing listingActivity = new Listing();
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