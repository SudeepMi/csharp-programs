using System;
using System.Collections.Generic;

class StringIndexerExample
{
    private Dictionary<string, string> data = new Dictionary<string, string>();

    // Indexer with a string parameter (other than int)
    public string this[string key]
    {
        get
        {
            if (data.ContainsKey(key))
            {
                return data[key];
            }
            else
            {
                throw new KeyNotFoundException($"Key '{key}' not found.");
            }
        }
        set
        {
            data[key] = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Indexer Example (Other than int Type Index)\n");

        StringIndexerExample example = new StringIndexerExample();

        // Setting values using the indexer
        example["name"] = "John";
        example["age"] = "30";
        example["city"] = "New York";

        // Getting values using the indexer
        Console.WriteLine($"Name: {example["name"]}");
        Console.WriteLine($"Age: {example["age"]}");
        Console.WriteLine($"City: {example["city"]}");
    }
}
