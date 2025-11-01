using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 20);
        int guess;

        do
        {
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();
            guess = int.Parse(input);

            if (guess > magicNumber)
            {
                Console.WriteLine("lower");
            }

            else if (guess < magicNumber)
            {
                Console.WriteLine("higher");
            }
        
            } while (guess != magicNumber);

        Console.WriteLine("You guessed correctly!");
    }
}