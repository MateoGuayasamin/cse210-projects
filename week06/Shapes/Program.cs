using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Square square = new Square(5,"blue");
        Console.WriteLine(square.GetArea());
        Console.WriteLine(square.GetColor());
        Rectangle rectangle = new Rectangle(5,10,"red");
        Console.WriteLine($"{rectangle.GetColor} {rectangle.GetArea}");

    }
}