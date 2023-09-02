using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Non-Generic and Generic Collections in C#\n");

        // Non-generic collection (ArrayList)
        ArrayList nonGenericList = new ArrayList();
        nonGenericList.Add(10);
        nonGenericList.Add("Hello");
        nonGenericList.Add(true);

        Console.WriteLine("Non-Generic Collection (ArrayList):");
        foreach (var item in nonGenericList)
        {
            Console.WriteLine(item);
        }

        // Generic collection (List<int>)
        List<int> genericList = new List<int>();
        genericList.Add(20);
        genericList.Add(30);
        genericList.Add(40);

        Console.WriteLine("\nGeneric Collection (List<int>):");
        foreach (var item in genericList)
        {
            Console.WriteLine(item);
        }
    }
}
