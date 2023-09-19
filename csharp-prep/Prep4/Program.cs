using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int num;

        do
        {
            Console.Write("Enter Number: ");
            string digit = Console.ReadLine();
            num = int.Parse(digit);
            if (num > 0)
            {
                numbers.Add(num);
            }
            

        } while (num != 0);
        
        int count = 0;
        int total = 0;
        int largest = 0;
        foreach (int number in numbers)
        {
            count ++;
            total += number;
            if (number > largest)
            {
                largest = number;
            }
        }
        int average = total/count;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}