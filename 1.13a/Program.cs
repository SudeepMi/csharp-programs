using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("File Handling using BinaryReader and BinaryWriter in C#\n");

        // Write data to a binary file
        using (BinaryWriter writer = new BinaryWriter(File.Open("binary_data.dat", FileMode.Create)))
        {
            writer.Write(42);
            writer.Write(3.14);
            writer.Write("Hello, BinaryWriter!");
        }

        // Read data from the binary file
        using (BinaryReader reader = new BinaryReader(File.Open("binary_data.dat", FileMode.Open)))
        {
            int intValue = reader.ReadInt32();
            double doubleValue = reader.ReadDouble();
            string stringValue = reader.ReadString();

            Console.WriteLine($"Read Integer: {intValue}");
            Console.WriteLine($"Read Double: {doubleValue}");
            Console.WriteLine($"Read String: {stringValue}");
        }
    }
}
