using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        RunningActivity runningActivity = new RunningActivity(30, 3);
        CyclingActivity cyclingActivity = new CyclingActivity(30, 15);
        SwimmingActivity swimmingActivity = new SwimmingActivity(30, 5);
        Console.WriteLine(runningActivity.GetSummary());
        Console.WriteLine(cyclingActivity.GetSummary());
        Console.WriteLine(swimmingActivity.GetSummary());
    }
}

