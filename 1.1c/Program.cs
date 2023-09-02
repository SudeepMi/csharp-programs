using System;

class Program
{
    private string message;

    public Program(string message)
    {
        Console.WriteLine("Lab: 1.1");
        Console.WriteLine("Name: Sudeep K Mishra");
        this.message = message;
    }

    public Program(Program other)
    {
        Console.WriteLine("Lab: 1.1");
        Console.WriteLine("Name: Sudeep K Mishra");
        this.message = other.message;
    }

    static void Main(string[] args)
    {
        Program original = new Program("Original Object");
        Program copy = new Program(original);
        Console.WriteLine("Copy Constructor Example");
    }
}
