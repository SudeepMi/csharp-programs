using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Exception Handling in C#\n");

        try
        {
            // Code that may throw an exception
            int result = Divide(10, 0); // Attempting to divide by zero
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException ex)
        {
            // Catching and handling the exception
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            // Code in the finally block always executes
            Console.WriteLine("Finally block executed.");
        }

        Console.WriteLine("Program continues after exception handling.");
    }

    // Function that may throw an exception
    static int Divide(int dividend, int divisor)
    {
        return dividend / divisor;
    }
}
