public class CheckListGoal : Goal
{
    private string _amountGoal;
    private string _amountDone = "0";

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
        _amountDone = int.Parse(_amountDone) + 1.ToString();
        goalManager.AddPoints(GetPoints());
    }

    public override string GetDetailsString()
    {
        string check = " ";
        if (IsComplete() == true)
        {
            check = "X";
        }
        return $"[{check}] {GetName()}: {GetDescription()} {_amountDone}/{_amountGoal}";
    }

    public CheckListGoal(string name, string description, string points, string amount)
        : base(name, description, points)
    {
        _amountGoal = amount;
    }
}
