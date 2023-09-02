using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Using Built-In Attributes in C#\n");

        // Applying the Obsolete attribute to a method
        DeprecatedMethod();
    }

    [Obsolete("This method is deprecated. Use NewMethod() instead.")]
    static void DeprecatedMethod()
    {
        Console.WriteLine("This method is deprecated.");
    }

    static void NewMethod()
    {
        Console.WriteLine("This is the new method.");
    }
}
