public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description)
        : base(name, description) { }

    public void Run()
    {
        Console.Clear();
        StartMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        Console.Clear();
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("");
            Console.Write("Breath in... ");
            ShowCountdown(5);
            Console.WriteLine("");
            Console.Write("Breath out... ");
            ShowCountdown(5);
        }
        EndMessage();
    }
}

