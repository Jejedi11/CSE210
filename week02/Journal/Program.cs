using System;
using System.IO.Enumeration;
using System.Net;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        string dirPath = @"journals";
        if (!Directory.Exists(dirPath))
        {
            Directory.CreateDirectory(dirPath);
        }

        List<string> prompts = new List<string>();
        prompts.Add("How did you see the hand of the Lord today?");
        prompts.Add("If I could be better at one Christlike attribute today, which would it be? ");
        prompts.Add("What is one thing you did today that you are proud of?");
        prompts.Add("What was the best part of my day?");

        string getPrompt()
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, prompts.Count());
            string prompt = prompts[number];
            return prompt;
        }
        int entryNum = 1;
        string response = "0";

        Journal journal = new Journal();
        while (response != "5") 
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            response = Console.ReadLine();
            if (response == "1")
            {
                journal.MakeEntry(getPrompt());
                
                entryNum++;
            }
            else if (response == "2")
            {
                journal.DisplayAll();
            }
            else if (response == "3")
            {
                var journalFolder = "journals";
                var dir = new DirectoryInfo(journalFolder);
                var results = dir.GetFiles();
                
                foreach (var file in results)
                {
                    Console.WriteLine(file);
                }
                
                Console.Write("Enter the file to load: ");
                string filename = Console.ReadLine();
                journal.LoadFile("journals/" + filename, journal);
            }
            else if (response == "4")
            {
                Console.Write("Save Journal as: ");
                string filename = Console.ReadLine();
                journal.SaveFile("journals/" + filename);
            }
            else if (response == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid option (1-5).");
            }
        }
        


    }
}