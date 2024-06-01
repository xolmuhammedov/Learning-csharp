using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Create a Stopwatch instance
        Stopwatch stopwatch = new Stopwatch();

        // Start the stopwatch
        stopwatch.Start();

        // Execute the loop
        for (int i = 0; i < 10000; i++)
        {
            Console.WriteLine(i);
        }
        
        // Stop the stopwatch
        stopwatch.Stop();

        // Get the elapsed time in seconds
        double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;

        // Display the elapsed time in seconds
        Console.WriteLine($"Duration: {elapsedSeconds:F3} seconds");
        
        int someNum = 30;
        Console.WriteLine(someNum);
        Console.WriteLine("so you think this is a fast language");

    }
}