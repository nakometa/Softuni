using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] waterBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> bottles = new Stack<int>(waterBottles);
            Queue<int> cups = new Queue<int>(cupsCapacity);
            int wastedLiters = 0;

            while (cups.Any() && bottles.Any())
            {
                if (bottles.Peek() > cups.Peek())
                {
                    wastedLiters += bottles.Pop() - cups.Dequeue();
                }
                else if (bottles.Peek() == cups.Peek())
                {
                    bottles.Pop();
                    cups.Dequeue();
                }
                else
                {
                    int cupSpaceLeft = cups.Dequeue() - bottles.Pop();
                    while (cupSpaceLeft > 0)
                    {
                        cupSpaceLeft -= bottles.Pop();
                        if (cupSpaceLeft < 0)
                        {
                            wastedLiters += Math.Abs(cupSpaceLeft);
                        }
                    }
                }
            }

            if (cups.Any())
            {
                Console.WriteLine($"Cups: {String.Join(" ",cups)}");
                Console.WriteLine($"Wasted litters of water: {wastedLiters}");
            }
            else
            {
                Console.WriteLine($"Bottles: {String.Join(" ", bottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedLiters}");
            }
        }
    }
}
