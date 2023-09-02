using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1.2");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Reverse String and Character Occurrence\n");

        // Input a string from the user
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        // Reverse the string and display it
        string reversedString = ReverseString(inputString);
        Console.WriteLine($"Reversed String: {reversedString}");

        // Display the occurrence of individual characters
        DisplayCharacterOccurrences(inputString);
    }

    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static void DisplayCharacterOccurrences(string input)
    {
        Dictionary<char, int> characterCount = new Dictionary<char, int>();

        foreach (char character in input)
        {
            if (char.IsLetterOrDigit(character)) // Count only letters and digits
            {
                if (characterCount.ContainsKey(character))
                {
                    characterCount[character]++;
                }
                else
                {
                    characterCount[character] = 1;
                }
            }
        }

        Console.WriteLine("\nCharacter Occurrences:");
        foreach (var kvp in characterCount)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} times");
        }
    }
}
