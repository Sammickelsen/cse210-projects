using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 5);
        Rectangle rectangle = new Rectangle("red", 2, 6);
        Circle circle = new Circle("yellow", 4);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine();
        }
    }
}