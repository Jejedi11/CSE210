public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public override bool IsComplete()
    {
        if (_isComplete == true)
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
        _isComplete = true;
        goalManager.AddPoints(GetPoints());
    }

    public SimpleGoal(string name, string description, string points, string isComplete)
        : base(name, description, points)
    {
        _isComplete = bool.Parse(isComplete);
    }

    public override string GetStringRepresentation()
    {
        return $"{GetName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }
}
