using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction = new Fraction(5);

        fraction.SetBottom(10);
        fraction.SetTop(6);
        Console.WriteLine(fraction.GetDecimalValue());
        Console.WriteLine(fraction.GetFractionalString());
    }
}
