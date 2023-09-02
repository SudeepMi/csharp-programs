using System;

// Enumeration (enum)
enum DaysOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

// Structure (struct)
struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"Point coordinates: ({X}, {Y})");
    }
}

// Partial class (part 1)
partial class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

// Partial class (part 2)
partial class Person
{
    public void DisplayFullName()
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Struct, Enumeration, and Partial Class in C#\n");

        // Enumeration
        DaysOfWeek today = DaysOfWeek.Wednesday;
        Console.WriteLine($"Today is {today}");

        // Structure
        Point point = new Point(5, 10);
        point.Display();

        // Partial class
        Person person = new Person();
        person.FirstName = "John";
        person.LastName = "Doe";
        person.DisplayFullName();
    }
}
