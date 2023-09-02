using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Custom Exception Handling in C#\n");

        try
        {
            WithdrawMoney(500, 300); // Attempting to withdraw more money than the balance
            Console.WriteLine("Withdrawal successful.");
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.WriteLine("Program continues after exception handling.");
    }

    // Custom exception class
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message) { }
    }

    // Method that throws a custom exception
    static void WithdrawMoney(decimal balance, decimal amount)
    {
        if (amount > balance)
        {
            throw new InsufficientBalanceException("Insufficient balance to withdraw.");
        }
        // Perform the withdrawal logic here
    }
}
