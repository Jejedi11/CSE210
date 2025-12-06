public abstract class Goal
{
    private string _name;
    private string _description;
    private string _points;

    public Goal(string name, string description, string points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();

    public string GetDetailsString()
    {
        return $"[] {_name}: {_description}";
    }
}
