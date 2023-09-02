using System;

class Program
{
    static Program()
    {
        Console.WriteLine("Lab: 1.1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Static Constructor Example");
    }

    public Program()
    {
        // Instance constructor
    }

    static void Main(string[] args)
    {
        Program program = new Program();
    }
}
