public class CheckListGoal : Goal
{
    private string _amountGoal;
    private string _amountDone = "0";
    private string _bonus;

    public override bool IsComplete()
    {
        if (int.Parse(_amountDone) >= int.Parse(_amountGoal))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void RecordEvent(GoalManager goalManager)
    {
        int amountInt = int.Parse(_amountDone);
        amountInt++;
        _amountDone = amountInt.ToString();
        goalManager.AddPoints(GetPoints());
        if (int.Parse(_amountDone) == int.Parse(_amountGoal))
        {
            goalManager.AddPoints(_bonus);
            Console.WriteLine($"You reached your goal and got a {_bonus} point bonus!");
        }
    }

    public override string GetDetailsString()
    {
        string check = " ";
        if (IsComplete() == true)
        {
            check = "X";
        }
        return $"[{check}] {GetName()}: ({GetDescription()}) -- Currently Completed: {_amountDone}/{_amountGoal}";
    }

    public CheckListGoal(
        string name,
        string description,
        string points,
        string amountGoal,
        string amountDone,
        string bonus
    )
        : base(name, description, points)
    {
        _amountGoal = amountGoal;
        _amountDone = amountDone;
        _bonus = bonus;
    }

    public override string GetStringRepresentation()
    {
        return $"{GetName()},{GetDescription()},{GetPoints()},{_amountGoal},{_amountDone},{_bonus}";
    }
}
