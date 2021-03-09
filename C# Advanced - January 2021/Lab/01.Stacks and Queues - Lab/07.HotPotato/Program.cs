using System;
using System.Collections.Generic;

namespace _07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> hotPotatoGame = new Queue<string>(kids);
            int counter = 0;

            while (hotPotatoGame.Count > 1)
            {
                bool removed = false;
                counter++;
                string kid = hotPotatoGame.Dequeue();
                if (counter == n)
                {
                    Console.WriteLine($"Removed {kid}");
                    removed = true;
                    counter = 0;
                }
                if (!removed)
                {
                    hotPotatoGame.Enqueue(kid);
                }
            }
            Console.WriteLine($"Last is {hotPotatoGame.Dequeue()}");
        }
    }
}
