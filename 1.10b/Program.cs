using System;

// Delegate declaration
delegate void MyDelegate(string message);

class Program
{
    // Method to be used with delegates
    static void DisplayMessage(string message)
    {
        Console.WriteLine($"Message: {message}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Delegates, Multicast Delegate, Func, Action, Anonymous Method, and Event in C#\n");

        // Delegate instantiation
        MyDelegate delegate1 = DisplayMessage;

        // Using the delegate
        delegate1("Hello, World!");

        // Multicast Delegate
        MyDelegate delegate2 = DisplayMessage;
        delegate2 += delegate (string msg) { Console.WriteLine($"Anonymous Delegate: {msg}"); };
        delegate2("Multicast Delegates");

        // Func Delegate
        Func<int, int, int> add = (a, b) => a + b;
        int result = add(5, 7);
        Console.WriteLine($"Func Delegate Result: {result}");

        // Action Delegate
        Action<string> print = (text) => Console.WriteLine($"Action Delegate: {text}");
        print("Action Delegates");

        // Anonymous Method
        MyDelegate delegate3 = delegate (string msg) { Console.WriteLine($"Anonymous Method: {msg}"); };
        delegate3("Using Anonymous Method");

        // Event
        MyEventPublisher publisher = new MyEventPublisher();
        MyEventListener listener = new MyEventListener();
        publisher.MyEvent += listener.OnMyEvent;
        publisher.PublishEvent("Event is fired.");
    }
}

// Event Publisher Class
class MyEventPublisher
{
    public event MyDelegate MyEvent;

    public void PublishEvent(string message)
    {
        MyEvent?.Invoke(message);
    }
}

// Event Listener Class
class MyEventListener
{
    public void OnMyEvent(string message)
    {
        Console.WriteLine($"Event Listener: {message}");
    }
}
