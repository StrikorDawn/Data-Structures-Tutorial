// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //TODO use what you have learned to make a Bug submission feature for our music app.
        Queue<string> bugQueue = new Queue<string>();
        //This is an example of how you could format your test cases.
        bugQueue.Enqueue("BugID:0001 - Cannot adjust volume of songs");
        //TODO create at least 3 additional items to be added to the bugQueue for testing.
        
        
        
        
        //----------------------------------------------------
        Console.WriteLine("Current Bug Queue:");
        foreach (var bug in bugQueue)
        {
            Console.WriteLine(bug);
        }
        //The expected result should be the test cases in the exact same order you put them in.
        //----------------------------------------------------
        //Now we are going to practice Dequeueing from the bugQueue
        //TODO Write at least 2 Dequeue statements
        bugQueue.Dequeue();
        
        //----------------------------------------------------
        Console.WriteLine("Updated Bug Queue:");
        foreach (var bug in bugQueue)
        {
            Console.WriteLine(bug);
        }
        //The expected result should be the test cases minus at least the first 2 in the exact same order you put them in.
        //----------------------------------------------------
    }
}