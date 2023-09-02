using System;

class Program
{
    public Program(string message)
    {
        Console.WriteLine("Lab: 1.1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Message: " + message);
    }

    static void Main(string[] args)
    {
        Program program = new Program("Parameterized Constructor Example");
    }
}
