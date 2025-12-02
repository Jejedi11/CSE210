public class Activity{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
    }
    public void EndMessage()
    {
        Console.Clear();
        Console.WriteLine("Well Done!");
        ShowSpinner(3);
        Console.WriteLine($"You completed {_duration} seconds of the {_name}");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            foreach (string symbol in animationStrings)
            {
                Console.Write(symbol);
                Thread.Sleep(300);
                Console.Write("\b \b");
            }
        }
    }
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public Activity (string name, string description)
    {
        _name = name;
        _description = description;
    }
    
}