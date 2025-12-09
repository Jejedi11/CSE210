using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        string choice = "";
        string goalType = "";
        GoalManager goalManager = new GoalManager();
        while (choice != "6")
        {
            Console.WriteLine("Total Points:" + goalManager.GetPoints());
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a Choice from the menu:");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Select a Goal type:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Which type of goal would you like to create?");
                goalType = Console.ReadLine();

                Console.Write("Enter a name for the new goal: ");
                string name = Console.ReadLine();
                Console.Write("Enter a description of the goal: ");
                string description = Console.ReadLine();
                Console.Write("How many points will be associated with this goal?");
                string points = Console.ReadLine();

                if (goalType == "1")
                {
                    goalManager.CreateGoal("simple", name, description, points);
                }
                else if (goalType == "2")
                {
                    goalManager.CreateGoal("eternal", name, description, points);
                }
                else if (goalType == "3")
                {
                    goalManager.CreateGoal("checkList", name, description, points);
                }
            }
            else if (choice == "2")
            {
                goalManager.ListGoals();
            }
            else if (choice == "5")
            {
                goalManager.ListGoals();
                Console.WriteLine("Which goal did you accomplish? ");
                string complete = Console.ReadLine();
            }
        }
    }
}
