using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Queue<string> songsQueue = new Queue<string>(input);
            string cmdArgs = Console.ReadLine();

            while (songsQueue.Any())
            {
                if (cmdArgs.Contains("Play"))
                {
                    songsQueue.Dequeue();
                    if (songsQueue.Count <= 0)
                    {
                        Console.WriteLine("No more songs!");
                    }
                }
                else if (cmdArgs.Contains("Add"))
                {
                    string[] song = cmdArgs.Split("Add ");
                    if (songsQueue.Contains(song[1]))
                    {
                        Console.WriteLine($"{song[1]} is already contained!");
                    }
                    else
                    {
                        songsQueue.Enqueue(song[1]);
                    }
                }
                else
                {
                    Console.WriteLine(String.Join(", ", songsQueue));
                }
                cmdArgs = Console.ReadLine();
            }
        }
    }
}
