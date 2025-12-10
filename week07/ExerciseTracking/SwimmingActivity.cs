public class SwimmingActivity : Activity
{
    private int _numOfLaps;

    public override string GetActivityType()
    {
        return "Swimming";
    }

    public override double GetDistance()
    {
        return (_numOfLaps * 50) / (1000 * 0.62);
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _length) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public SwimmingActivity(double length, int numofLaps)
        : base(length)
    {
        _numOfLaps = numofLaps;
    }
}
