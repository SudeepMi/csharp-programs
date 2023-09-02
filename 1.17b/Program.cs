using System;

// Define a custom attribute
[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
sealed class CustomAttribute : Attribute
{
    public string Description { get; }

    public CustomAttribute(string description)
    {
        Description = description;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Creating and Using Custom Attributes in C#\n");

        // Applying the custom attribute to a method
        PrintInfo();
    }

    [Custom("This method provides information.")]
    static void PrintInfo()
    {
        // Retrieve custom attribute information
        CustomAttribute attribute = (CustomAttribute)Attribute.GetCustomAttribute(
            typeof(Program).GetMethod("PrintInfo"),
            typeof(CustomAttribute));

        if (attribute != null)
        {
            Console.WriteLine($"Description: {attribute.Description}");
        }
    }
}
