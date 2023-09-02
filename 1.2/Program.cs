using System;

class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        Console.WriteLine("Lab: 1.2");
        Console.WriteLine("Name: Sudeep K Mishra");
        Name = name; // Using the property setter
        Age = age;   // Using the property setter
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
            {
                age = value;
            }
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("John Doe", 30);
        person.DisplayInfo();

        // Attempt to set invalid values
        person.Name = "";  // This won't change the name
        person.Age = -5;   // This won't change the age

        Console.WriteLine("\nAfter Attempting to Set Invalid Values:");
        person.DisplayInfo();
    }
}
