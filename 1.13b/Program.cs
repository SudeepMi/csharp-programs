using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("File Handling using FileStream in C#\n");

        // Write data to a file using FileStream
        using (FileStream fileStream = new FileStream("file_stream_data.txt", FileMode.Create))
        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.WriteLine("Hello, FileStream!");
            writer.WriteLine("This is a test.");
        }

        // Read data from the file using FileStream
        using (FileStream fileStream = new FileStream("file_stream_data.txt", FileMode.Open))
        using (StreamReader reader = new StreamReader(fileStream))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
