using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Lambda Expressions and LINQ in C#\n");

        // Sample list of integers
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Statement Lambda Expression to filter even numbers
        var evenNumbers = numbers.Where((num) =>
        {
            if (num % 2 == 0)
                return true;
            else
                return false;
        });

        Console.WriteLine("Even Numbers (Statement Lambda):");
        foreach (var num in evenNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Expression Lambda Expression to filter odd numbers
        var oddNumbers = numbers.Where(num => num % 2 != 0);

        Console.WriteLine("\nOdd Numbers (Expression Lambda):");
        foreach (var num in oddNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
