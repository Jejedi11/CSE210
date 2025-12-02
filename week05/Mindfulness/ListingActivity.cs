using Microsoft.VisualBasic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public void Run()
    {
        Console.Clear();
        StartMessage();
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("You may begin in ");
        ShowCountdown(5);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"You listed {_count} items!");
        ShowSpinner(5);
        EndMessage();
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(1, _prompts.Count)];
    }

    public ListingActivity(string name, string description, List<string> prompts) : base(name, description)
    {
        _prompts = prompts;
        _count = 0;
    }
}