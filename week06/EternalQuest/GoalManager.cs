public class GoalManager
{
    public void CreateGoal(string type)
    {
        if (type == "simple")
        {
            SimpleGoal goal = new SimpleGoal();
        }
    }
}
