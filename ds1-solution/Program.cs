// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a queue to represent the bug submission queue
        Queue<string> bugQueue = new Queue<string>();

        // Simulate bug submissions by adding them to the queue
        bugQueue.Enqueue("Bug 1: UI glitch on login screen");
        bugQueue.Enqueue("Bug 2: Error message not displaying properly");
        bugQueue.Enqueue("Bug 3: Application crashes when clicking button");

        // Display the current bug queue
        Console.WriteLine("Current Bug Queue:");

        foreach (var bug in bugQueue)
        {
            Console.WriteLine(bug);
        }

        bugQueue.Dequeue();
        

        // Simulate fixing bugs by dequeuing them (handling them one by one)
        Console.WriteLine("Updated Bug Queue:");
        foreach (var bug in bugQueue)
        {
            Console.WriteLine(bug);
        }
        
    }
}