using System;

class Program
{
    static void Main(string[] args)
    {
        //Create three seperate fraction objects.
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(6, 8);

        //Check GetTop and GetBottom.
        // Console.WriteLine(fraction1.GetTop());
        // Console.WriteLine(fraction3.GetBottom());
        // Console.WriteLine();

        //Check SetTop and SetBottom.
        // fraction1.SetTop(4);
        // fraction3.SetBottom(9);
        // Console.WriteLine(fraction1.GetTop());
        // Console.WriteLine(fraction3.GetBottom());
        // Console.WriteLine();

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
    }
}