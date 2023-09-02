using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Take Input from Keyboard and Write to a File in C#\n");

        Console.Write("Enter text to write to the file: ");
        string inputText = Console.ReadLine();

        string filePath = "user_input.txt";

        try
        {
            // Write user input to a file
            File.WriteAllText(filePath, inputText);

            Console.WriteLine($"Text written to '{filePath}' successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
