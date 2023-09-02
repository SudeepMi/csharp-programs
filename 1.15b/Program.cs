using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("LINQ with Lambda Expressions in C#\n");

        // Sample list of products
        List<Product> products = new List<Product>
        {
            new Product { ID = 1, Name = "Laptop", Price = 1000 },
            new Product { ID = 2, Name = "Smartphone", Price = 500 },
            new Product { ID = 3, Name = "Tablet", Price = 300 },
            new Product { ID = 4, Name = "Monitor", Price = 200 },
            new Product { ID = 5, Name = "Keyboard", Price = 50 }
        };

        // LINQ query to filter expensive products using expression lambda
        var expensiveProducts = products.Where(product => product.Price > 300);

        Console.WriteLine("Expensive Products (Price > 300):");
        foreach (var product in expensiveProducts)
        {
            Console.WriteLine($"ID: {product.ID}, Name: {product.Name}, Price: {product.Price:C}");
        }
    }

    // Sample Product class
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
