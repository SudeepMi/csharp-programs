using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

class Dog : Animal
{
    // Method hiding (shadowing) by introducing a new method with the same name
    public new void Eat()
    {
        Console.WriteLine("Dog is eating.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Method Hiding (Shadowing) in C#\n");

        Animal animal = new Animal();
        Dog dog = new Dog();

        // Demonstrating method hiding
        Console.WriteLine("Demonstrating Method Hiding (Shadowing):");
        animal.Eat(); // Calls the Animal class method
        dog.Eat(); // Calls the Dog class method (hiding the base class method)
    }
}
