using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Thread.Sleep(5000);
        Console.Clear();
        string action = "";
        while (action != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            action = Console.ReadLine();
            if (action == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathingActivity.Run();
            }
            else if (action == "2")
            {
                List<string> prompts = new List<string>();
                prompts.Add("Think of a time when you stood up for someone else.");
                prompts.Add("Think of a time when you did something really difficult.");
                prompts.Add("Think of a time when you helped someone in need.");
                prompts.Add("Think of a time when you did something truly selfless.");
                List<string> questions = new List<string>();
                questions.Add("Have you ever done anything like this before?");
                questions.Add("How did you get started?");
                questions.Add("How did you feel when it was complete?");
                questions.Add("What made this time different than other times when you were not as successful?");
                questions.Add("What is your favorite thing about this experience?");
                questions.Add("What could you learn from this experience that applies to other situations?");
                questions.Add("What did you learn about yourself through this experience?");
                questions.Add("How can you keep this experience in mind in the future?");
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", prompts, questions);
                reflectingActivity.Run();
            }
            else if (action == "3")
            {
                List<string> prompts = new List<string>();
                prompts.Add("Who are people that you appreciate?");
                prompts.Add("What are personal strengths of yours?");
                prompts.Add("Who are people that you have helped this week?");
                prompts.Add("When have you felt the Holy Ghost this month?");
                prompts.Add("Who are some of your personal heroes?");
                ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", prompts);
                listingActivity.Run();
            }
            else if (action == "4")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Please enter a valid option: ");
            }
        }
    }
}