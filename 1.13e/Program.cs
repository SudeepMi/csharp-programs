using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Read and Write to Another File in C#\n");

        // Read all contents of a file
        string sourceFilePath = "source_file.txt";
        string targetFilePath = "target_file.txt";

        try
        {
            string[] lines = File.ReadAllLines(sourceFilePath);

            // Write contents to another file
            File.WriteAllLines(targetFilePath, lines);

            Console.WriteLine($"Contents from '{sourceFilePath}' copied to '{targetFilePath}' successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
