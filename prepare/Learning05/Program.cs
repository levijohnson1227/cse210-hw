using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Blue",10);
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Red", 10, 15);
        // Console.WriteLine(rectangle.GetColor());
        // Console.WriteLine(rectangle.GetArea());
        shapes.Add(rectangle);

        Circle circle = new Circle("Indigo", 10);
        // Console.WriteLine(circle.GetColor());
        // Console.WriteLine(circle.GetArea());
        shapes.Add(circle);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"Shape color: {color}, Shape Area: {area}");
        }
    }
}