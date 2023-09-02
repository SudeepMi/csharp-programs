using System;

// Abstract class
abstract class Shape
{
    public abstract void Draw(); // Abstract method, must be implemented by derived classes
}

// Concrete class inheriting from the abstract class
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Abstract Class in C#\n");

        Shape shape = new Circle();
        shape.Draw(); // Calls the Draw method of the Circle class
    }
}
