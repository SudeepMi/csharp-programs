using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }

    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Method Overriding (Dynamic Polymorphism) in C#\n");

        Animal animal = new Animal();
        Animal dogAsAnimal = new Dog(); // Upcasting

        // Demonstrating method overriding (dynamic polymorphism)
        Console.WriteLine("Demonstrating Method Overriding:");
        animal.MakeSound(); // Calls the Animal class method
        dogAsAnimal.MakeSound(); // Calls the Dog class method due to method overriding
    }
}
