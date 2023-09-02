using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1.2");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Enter ten words:");

        // Create an array to store the words
        string[] words = new string[10];

        // Read words from the user
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter word {i + 1}: ");
            words[i] = Console.ReadLine();
        }

        // Sort the array in ascending order
        Array.Sort(words);

        // Display the words in ascending order
        Console.WriteLine("\nWords in ascending order:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}
