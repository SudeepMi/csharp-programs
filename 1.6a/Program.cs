using System;

class Animal
{
    protected string name;

    public Animal(string name)
    {
        this.name = name;
    }

    public void Eat()
    {
        Console.WriteLine($"{name} is eating.");
    }

    public virtual void MakeSound()
    {
        Console.WriteLine($"{name} makes a sound.");
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public void Bark()
    {
        Console.WriteLine($"{name} is barking.");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{name} barks.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Using 'base' Keyword in Inheritance\n");

        Dog dog = new Dog("Buddy");


        // Call base class method using 'base' keyword
        dog.Eat();
        dog.MakeSound();

        // Call derived class method
        dog.Bark();
    }
}
