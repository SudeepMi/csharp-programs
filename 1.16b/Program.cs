using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Exception Handling with 'throw' in C#\n");

        try
        {
            ValidateAge(15); // Calling a method that uses 'throw' to raise an exception
            Console.WriteLine("Age is valid.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.WriteLine("Program continues after exception handling.");
    }

    // Method that uses 'throw' to raise a custom exception
    static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new ArgumentException("Age must be 18 or older.");
        }
    }
}
