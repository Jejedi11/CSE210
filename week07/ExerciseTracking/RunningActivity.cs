public class RunningActivity : Activity
{
    private double _distance;

    public override string GetActivityType()
    {
        return "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _length) * 60;
    }

    public override double GetPace()
    {
        return _length / _distance;
    }

    public RunningActivity(double length, double distance)
        : base(length)
    {
        _distance = distance;
    }
}
