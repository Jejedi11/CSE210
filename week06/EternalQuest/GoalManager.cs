using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;

    public Goal GetGoal(int i)
    {
        return _goals[i];
    }

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
            SimpleGoal goal = new SimpleGoal(name, description, points, "false");
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
            Console.Write("How much is the bonus for completing this goal? ");
            string bonus = Console.ReadLine();
            CheckListGoal goal = new CheckListGoal(name, description, points, amount, "0", bonus);
            _goals.Add(goal);
        }
    }

    public void ListGoals()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(i + ". " + goal.GetDetailsString());
            i++;
        }
    }

    public string GetUserLevel()
    {
        if (_totalPoints > 700)
        {
            return "level 6 --Jedi Grand Master";
        }
        else if (_totalPoints >= 500)
        {
            return "level 5 --Jedi Master";
        }
        else if (_totalPoints >= 300)
        {
            return "level 4 --Jedi Knight";
        }
        else if (_totalPoints >= 100)
        {
            return "level 3 --Apprentice";
        }
        else if (_totalPoints >= 50)
        {
            return "Level 2 --Padawan";
        }
        else if (_totalPoints <= 50)
        {
            return "Level 1 --Youngling";
        }
        else
        {
            return "Level Unkown --Sith";
        }
    }

    public void LoadGoals(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            if (parts.Count() == 1)
            {
                _totalPoints = int.Parse(parts[0]);
            }
            else if (parts.Count() == 3)
            {
                EternalGoal eternalGoal = new EternalGoal(parts[0], parts[1], parts[2]);
                _goals.Add(eternalGoal);
            }
            else if (parts.Count() == 4)
            {
                SimpleGoal simpleGoal = new SimpleGoal(parts[0], parts[1], parts[2], parts[3]);
                _goals.Add(simpleGoal);
            }
            else if (parts.Count() == 6)
            {
                CheckListGoal checkListGoal = new CheckListGoal(
                    parts[0],
                    parts[1],
                    parts[2],
                    parts[3],
                    parts[4],
                    parts[5]
                );
                _goals.Add(checkListGoal);
            }
            else
            {
                Console.WriteLine("Please Enter a valid file");
            }
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalPoints);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
}
