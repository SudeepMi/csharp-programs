using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Extract Substring and Convert to Uppercase\n");

        // Input a string from the user
        Console.Write("Enter a string with a comma: ");
        string inputString = Console.ReadLine();

        // Find the position of the first comma
        int commaIndex = inputString.IndexOf(',');

        if (commaIndex >= 0)
        {
            // Extract the substring before the first comma
            string substringBeforeComma = inputString.Substring(0, commaIndex);

            // Convert the substring to uppercase
            string uppercaseSubstring = substringBeforeComma.ToUpper();

            Console.WriteLine($"Original String: {inputString}");
            Console.WriteLine($"Substring before first comma: {uppercaseSubstring}");
        }
        else
        {
            Console.WriteLine("No comma found in the input string.");
        }
    }
}
