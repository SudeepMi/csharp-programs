using System;

class MatrixMultiplication
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1.3");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Matrix Multiplication\n");

        // Input the dimensions of the matrices
        Console.Write("Enter the number of rows for the first matrix: ");
        int rowsA = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns for the first matrix: ");
        int colsA = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of rows for the second matrix: ");
        int rowsB = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns for the second matrix: ");
        int colsB = int.Parse(Console.ReadLine());

        // Check if multiplication is possible
        if (colsA != rowsB)
        {
            Console.WriteLine("Matrix multiplication is not possible. The number of columns in the first matrix must equal the number of rows in the second matrix.");
        }
        else
        {
            // Input the elements of the matrices
            int[,] matrixA = new int[rowsA, colsA];
            int[,] matrixB = new int[rowsB, colsB];

            Console.WriteLine("Enter the elements of the first matrix:");
            InputMatrixElements(matrixA);

            Console.WriteLine("Enter the elements of the second matrix:");
            InputMatrixElements(matrixB);

            // Perform matrix multiplication
            int[,] resultMatrix = MultiplyMatrices(matrixA, matrixB);

            // Display the result
            Console.WriteLine("Result of matrix multiplication:");
            DisplayMatrix(resultMatrix);
        }
    }

    static void InputMatrixElements(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"Enter element at position [{i}, {j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int colsB = matrixB.GetLength(1);

        int[,] resultMatrix = new int[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                resultMatrix[i, j] = 0;
                for (int k = 0; k < colsA; k++)
                {
                    resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return resultMatrix;
    }

    static void DisplayMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
