using System;

// Interface 1
interface IShape
{
    void Draw();
}

// Interface 2
interface IColor
{
    void FillColor();
}

// Class implementing both interfaces
class Circle : IShape, IColor
{
    public void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }

    public void FillColor()
    {
        Console.WriteLine("Filling the circle with color");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Multiple Inheritance Using Interfaces in C#\n");

        Circle circle = new Circle();
        circle.Draw(); // Calls the Draw method from IShape
        circle.FillColor(); // Calls the FillColor method from IColor
    }
}
