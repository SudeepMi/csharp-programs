using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("File Handling using StreamReader and StreamWriter in C#\n");

        // Write data to a file using StreamWriter
        using (StreamWriter writer = new StreamWriter("stream_writer_data.txt"))
        {
            writer.WriteLine("Hello, StreamWriter!");
            writer.WriteLine("This is a test.");
        }

        // Read data from the file using StreamReader
        using (StreamReader reader = new StreamReader("stream_writer_data.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
