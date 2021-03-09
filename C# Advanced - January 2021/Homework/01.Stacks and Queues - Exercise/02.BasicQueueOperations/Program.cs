using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> integers = new Queue<int>(input);

            for (int i = 0; i < data[1]; i++)
            {
                integers.Dequeue();
            }

            if (integers.Contains(data[2]))
            {
                Console.WriteLine("true");
            }
            else if (integers.Any())
            {
                Console.WriteLine(integers.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
