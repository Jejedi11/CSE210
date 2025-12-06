public class Circle : Shape
{
    private double _radius;

    public override double GetArea()
    {
        return Math.Pow(_radius, 2) * Math.PI;
    }

    public Circle(string color, double radius)
        : base(color)
    {
        _radius = radius;
    }
}
