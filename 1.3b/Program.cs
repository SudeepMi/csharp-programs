using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1.3");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Demonstrating Jagged Arrays\n");

        // Create a jagged array of integers
        int[][] jaggedArray = new int[3][];

        // Initialize subarrays with different lengths
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        // Access and display elements
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.Write($"Row {i + 1}: ");
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
