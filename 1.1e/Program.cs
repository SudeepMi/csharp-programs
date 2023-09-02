using System;

class Singleton
{
    private static Singleton instance;

    private Singleton()
    {
        Console.WriteLine("Lab: 1.1");
        Console.WriteLine("Name: Sudeep K Mishra");
    }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Singleton singleton1 = Singleton.Instance;
        Singleton singleton2 = Singleton.Instance;
        Console.WriteLine("Private Constructor (Singleton Pattern) Example");
    }
}
