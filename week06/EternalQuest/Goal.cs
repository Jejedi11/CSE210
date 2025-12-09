public abstract class Goal
{
    private string _name;
    private string _description;
    private string _points;

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetPoints()
    {
        return _points;
    }

    public Goal(string name, string description, string points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent(GoalManager goalManager);
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string check = " ";
        if (IsComplete() == true)
        {
            check = "X";
        }
        return $"[{check}] {_name}: ({_description})";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_name},{_description},{_points}";
    }
}
