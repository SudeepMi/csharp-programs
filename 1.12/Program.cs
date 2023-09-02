using System;

// Generic class
class GenericClass<T>
{
    private T genericField;

    public GenericClass(T value)
    {
        genericField = value;
    }

    public T GetValue()
    {
        return genericField;
    }

    public void ShowType()
    {
        Console.WriteLine($"Type of genericField: {typeof(T)}");
    }

    // Generic method
    public void DisplayValue<U>(U value)
    {
        Console.WriteLine($"Value of genericField: {genericField}");
        Console.WriteLine($"Value of method parameter: {value}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Generic Class, Generic Field, and Generic Method in C#\n");

        // Creating an instance of GenericClass with int type
        GenericClass<int> intGenericClass = new GenericClass<int>(42);

        int intValue = intGenericClass.GetValue();
        intGenericClass.ShowType();
        intGenericClass.DisplayValue("This is a string"); // Calling generic method with a different type

        // Creating an instance of GenericClass with string type
        GenericClass<string> stringGenericClass = new GenericClass<string>("Hello, Generics!");

        string stringValue = stringGenericClass.GetValue();
        stringGenericClass.ShowType();
        stringGenericClass.DisplayValue(3.14); // Calling generic method with a different type
    }
}
