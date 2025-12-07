public class SimpleGoal : Goal
{
    public override bool IsComplete()
    {

        return true;
    }

    public override void RecordEvent()
    {
    }

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {

    }
}
