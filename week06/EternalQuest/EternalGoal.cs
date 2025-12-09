public class EternalGoal : Goal
{
    public override bool IsComplete()
    {
        return false;
    }

    public override void RecordEvent(GoalManager goalManager)
    {
        goalManager.AddPoints(GetPoints());
    }

    public EternalGoal(string name, string description, string points)
        : base(name, description, points) { }
}
