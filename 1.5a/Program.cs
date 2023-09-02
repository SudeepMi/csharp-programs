using System;

class IntIndexerExample
{
    private int[] data = new int[10];

    // Indexer with an int parameter
    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < data.Length)
            {
                return data[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }
        set
        {
            if (index >= 0 && index < data.Length)
            {
                data[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Indexer Example (int Type Index)\n");

        IntIndexerExample example = new IntIndexerExample();

        // Setting values using the indexer
        example[0] = 100;
        example[1] = 200;
        example[2] = 300;

        // Getting values using the indexer
        Console.WriteLine($"Value at index 0: {example[0]}");
        Console.WriteLine($"Value at index 1: {example[1]}");
        Console.WriteLine($"Value at index 2: {example[2]}");
    }
}
