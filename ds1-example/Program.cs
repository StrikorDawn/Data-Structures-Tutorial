using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a queue to represent the music app queue
        Queue<string> musicQueue = new Queue<string>();

        // Enqueue some songs to the queue
        musicQueue.Enqueue("Song 1 - Artist 1");
        musicQueue.Enqueue("Song 2 - Artist 2");
        musicQueue.Enqueue("Song 3 - Artist 3");

        // Display the current playlist
        Console.WriteLine("Current Playlist:");

        foreach (var song in musicQueue)
        {
            Console.WriteLine(song);
        }

        // Dequeue a song (simulate playing the next song)
        Console.WriteLine("\nNow Playing: " + musicQueue.Dequeue());

        // Display the updated playlist
        Console.WriteLine("\nUpdated Playlist:");

        foreach (var song in musicQueue)
        {
            Console.WriteLine(song);
        }
    }
}