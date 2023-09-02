using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Check if a String Starts and Ends with Substrings\n");

        // Input a string from the user
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        // Input the starting and ending substrings
        Console.Write("Enter the starting substring: ");
        string startSubstring = Console.ReadLine();

        Console.Write("Enter the ending substring: ");
        string endSubstring = Console.ReadLine();

        // Check if the string starts and ends with the specified substrings
        bool startsWithSubstring = inputString.StartsWith(startSubstring, StringComparison.OrdinalIgnoreCase);
        bool endsWithSubstring = inputString.EndsWith(endSubstring, StringComparison.OrdinalIgnoreCase);

        // Display the results
        if (startsWithSubstring && endsWithSubstring)
        {
            Console.WriteLine($"The string '{inputString}' starts with '{startSubstring}' and ends with '{endSubstring}'.");
        }
        else if (startsWithSubstring)
        {
            Console.WriteLine($"The string '{inputString}' starts with '{startSubstring}' but does not end with '{endSubstring}'.");
        }
        else if (endsWithSubstring)
        {
            Console.WriteLine($"The string '{inputString}' ends with '{endSubstring}' but does not start with '{startSubstring}'.");
        }
        else
        {
            Console.WriteLine($"The string '{inputString}' does not start with '{startSubstring}' and does not end with '{endSubstring}'.");
        }
    }
}
