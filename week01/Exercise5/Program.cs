using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project. ");

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program. ");
        }

        static string PromptUserName()
        {
            Console.Write("Enter your name. ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Enter your favorite number. ");
            string input = Console.ReadLine();
            int userNumber = int.Parse(input);
            return userNumber;
        }

        static int SquareNumber(int input)
        {
            int squared = input * input;
            return squared;
        }

        static void DisplayResult(string name, int squared)
        {
            Console.WriteLine($"Name: {name} Squared: {squared}");
        }

        static void Main()
        {
            DisplayWelcome();
            string name = PromptUserName();
            int number = PromptUserNumber();
            int squared = SquareNumber(number);
            DisplayResult(name, squared);
        }

        Main();

    }
}