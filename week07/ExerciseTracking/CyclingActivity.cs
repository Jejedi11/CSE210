public class CyclingActivity : Activity
{
    private double _speed;

    public override string GetActivityType()
    {
        return "Cycling";
    }

    public override double GetDistance()
    {
        return GetPace() * _length;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public CyclingActivity(double length, double speed)
        : base(length)
    {
        _speed = speed;
    }
}
