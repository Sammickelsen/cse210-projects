using System;

class Program
{
    static void Main(string[] args)
    {
        bool loopControl = true;

        while (loopControl = true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            int response = Console.ReadLine();

            if (response = 1)
            {
                Console.WriteLine("Breathe Activity");
            }
            else if (response = 2)
            {
                Console.WriteLine("Reflecting Activity");
            }
            else if (response = 3)
            {
                Console.WriteLine("Listing Activity");
            }
            else if (response = 4)
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