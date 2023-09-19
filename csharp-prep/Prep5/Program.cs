using System;
using System.Globalization;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter a number: ");
        string numberString = Console.ReadLine();
        int number = int.Parse(numberString);
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(int square, string username)
    {
        Console.WriteLine($"{username}, the square of your number is {square}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(square, username);
        


    }
}