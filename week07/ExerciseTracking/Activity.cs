public abstract class Activity
{
    private DateTime _date;

    // Minutes
    protected double _length;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetActivityType();

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetActivityType()} ({_length} min): Distance {GetDistance()}, Speed: {GetSpeed()}, Pace: {GetPace()} min per mile";
    }

    public Activity(double length)
    {
        _date = DateTime.Now;
        _length = length;
    }
}
