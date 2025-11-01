using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        string input;
        int item = -1;

        while (item != 0)
        {
            Console.Write("Enter a number to add to the list (enter 0 to finsh). ");
            input = Console.ReadLine();
            item = int.Parse(input);
            if (item == 0)
            {
                break;
            }
            numbers.Add(item);
        }

        int sum = 0;

        foreach (int i in numbers)
        {
            sum += i;
        }

        int average = sum / numbers.Count();

        int largest = 0;

        foreach (int i in numbers)
        {
            if (i > largest)
            {
                largest = i;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest is: {largest}");
    }
}