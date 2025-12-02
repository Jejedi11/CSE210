public class ReflectingActivity : Activity{
    private List<string> _prompts;
    private List<string> _questions;

    public void Run()
    {
        Console.Clear();
        StartMessage();
        Console.Clear();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Now Ponder the following questions as they relate to this experience. ");
        Console.WriteLine($"You may begin in ");
        ShowCountdown(5);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetRandomQuestion() + "");
            ShowSpinner(10);
        }
        EndMessage();

       
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int promptNum = random.Next(1, _prompts.Count);
        return _prompts[promptNum];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int questionNum = random.Next(1,_questions.Count);
        return _questions[questionNum];
    }
    public ReflectingActivity(string name, string description, List<string> prompts, List<string> questions) : base(name, description)
    {
        _prompts = prompts;
        _questions = questions;
    }
}
