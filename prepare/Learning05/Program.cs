using System;
using System.Collections.ObjectModel;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("red", 3.5 );
        Console.WriteLine($"The color of the square is {square1.GetColor()}, the area of the square is {square1.GetArea()}");
        Rectangle rectangle1 = new Rectangle("blue", 55, 60);
        Console.WriteLine($"The color of the rectangle is {rectangle1.GetColor()}, the area of the rectangle is {rectangle1.GetArea()}");
        Circle circle1 = new Circle("orange", 222);
        Console.WriteLine($"The color of the circle is {circle1.GetColor()}, the area of the circle is {circle1.GetArea()}");
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("purple", 65));
        shapes.Add(new Rectangle("skyblue", 64, 98));
        shapes.Add(new Circle("black", 77));
        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}