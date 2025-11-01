using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Enter your current grade. ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        string letter = null;


        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else if (grade < 60)
        {
            letter = "F";
        }

        else
        {
            Console.WriteLine("Please enter a valid grade.");
        }

        Console.WriteLine($"You have a(n) {letter}.");
        if (grade >= 70)
        {
            Console.WriteLine("You are passing. Good job!");
        }

        else if (grade < 70)
        {
            Console.WriteLine("You are failing. Keep at it for nexxt time.");
        }
    }
}