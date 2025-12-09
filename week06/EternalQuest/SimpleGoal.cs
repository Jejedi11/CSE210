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

    public SimpleGoal(string name, string description, string points)
        : base(name, description, points) { }
}
