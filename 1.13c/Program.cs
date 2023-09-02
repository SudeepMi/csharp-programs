using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("File Handling using TextReader and TextWriter in C#\n");

        // Write data to a file using TextWriter
        using (TextWriter writer = File.CreateText("text_writer_data.txt"))
        {
            writer.WriteLine("Hello, TextWriter!");
            writer.WriteLine("This is a test.");
        }

        // Read data from the file using TextReader
        using (TextReader reader = File.OpenText("text_writer_data.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
