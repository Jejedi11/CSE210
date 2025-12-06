using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("green", 5));
        shapes.Add(new Rectangle("blue", 10, 12));
        shapes.Add(new Circle("brown", 7));
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}
