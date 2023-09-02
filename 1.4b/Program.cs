using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Count Characters, Words, and Word Occurrences\n");

        // Input a string from the user
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        // Count and display the total number of characters
        int totalCharacters = inputString.Length;
        Console.WriteLine($"Total Characters: {totalCharacters}");

        // Count and display the total number of words
        int totalWords = CountWords(inputString);
        Console.WriteLine($"Total Words: {totalWords}");

        // Display the occurrence of each word
        Dictionary<string, int> wordOccurrences = CountWordOccurrences(inputString);
        Console.WriteLine("\nWord Occurrences:");
        foreach (var kvp in wordOccurrences)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} times");
        }
    }

    static int CountWords(string input)
    {
        string[] words = input.Split(new[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    static Dictionary<string, int> CountWordOccurrences(string input)
    {
        string[] words = input.Split(new[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> wordOccurrences = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        foreach (string word in words)
        {
            if (wordOccurrences.ContainsKey(word))
            {
                wordOccurrences[word]++;
            }
            else
            {
                wordOccurrences[word] = 1;
            }
        }

        return wordOccurrences;
    }
}
