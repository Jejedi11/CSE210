public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;

    public void AddPoints(string points)
    {
        _totalPoints += int.Parse(points);
    }

    public int GetPoints()
    {
        return _totalPoints;
    }

    public void CreateGoal(string type, string name, string description, string points)
    {
        if (type == "simple")
        {
            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (type == "eternal")
        {
            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (type == "checkList")
        {
            Console.Write("How many times does this goal need to be repeated? ");
            string amount = Console.ReadLine();
            CheckListGoal goal = new CheckListGoal(name, description, points, amount);
            _goals.Add(goal);
        }
    }

    public void ListGoals()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
}
