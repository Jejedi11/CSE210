using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 5;
        Console.Write(x);
        Console.WriteLine("Hello World! This is the Sandbox Project.");
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine();

        if (name == "James") 
        {
            Console.WriteLine($"Your name is {name}");
        }
        
    }
}