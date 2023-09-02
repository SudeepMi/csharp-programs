using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Lab: 1");
        Console.WriteLine("Name: Sudeep K Mishra");
        Console.WriteLine("Asynchronous Programming with async/await in C#\n");

        // URL of a hypothetical web service
        string apiUrl = "https://jsonplaceholder.typicode.com/posts/1";

        try
        {
            // Perform an asynchronous HTTP GET request
            string result = await FetchDataAsync(apiUrl);

            Console.WriteLine($"Data from Web Service: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    static async Task<string> FetchDataAsync(string apiUrl)
    {
        using (HttpClient httpClient = new HttpClient())
        {
            // Send an asynchronous GET request
            HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

            // Check if the request was successful
            response.EnsureSuccessStatusCode();

            // Read and return the content as a string
            return await response.Content.ReadAsStringAsync();
        }
    }
}
