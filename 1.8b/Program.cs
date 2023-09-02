using System;

// Interface
interface IDrawable
{
    void Draw();
}

// Class implementing the interface
class Rectangle : IDrawable
{
    public void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Interface in C#\n");

        IDrawable drawable = new Rectangle();
        drawable.Draw(); // Calls the Draw method of the Rectangle class
    }
}
