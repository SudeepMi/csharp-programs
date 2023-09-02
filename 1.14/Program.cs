using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    // Define a sample class
    class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("LINQ (Language-Integrated Query) in C#\n");

        // Create a list of student objects
        List<Student> students = new List<Student>
        {
            new Student { StudentID = 1, Name = "Alice", Age = 20 },
            new Student { StudentID = 2, Name = "Bob", Age = 22 },
            new Student { StudentID = 3, Name = "Charlie", Age = 21 },
            new Student { StudentID = 4, Name = "David", Age = 23 },
            new Student { StudentID = 5, Name = "Eve", Age = 19 }
        };

        // LINQ Query to filter students older than 20
        var query = from student in students
                    where student.Age > 20
                    select student;

        Console.WriteLine("Students older than 20:");
        foreach (var student in query)
        {
            Console.WriteLine($"StudentID: {student.StudentID}, Name: {student.Name}, Age: {student.Age}");
        }

        // LINQ Method Syntax to filter students named "Bob"
        var bobs = students.Where(student => student.Name == "Bob");

        Console.WriteLine("\nStudents named 'Bob':");
        foreach (var student in bobs)
        {
            Console.WriteLine($"StudentID: {student.StudentID}, Name: {student.Name}, Age: {student.Age}");
        }

        // LINQ Method Syntax to find the average age of students
        double averageAge = students.Average(student => student.Age);

        Console.WriteLine($"\nAverage Age of Students: {averageAge:F2}");
    }
}
