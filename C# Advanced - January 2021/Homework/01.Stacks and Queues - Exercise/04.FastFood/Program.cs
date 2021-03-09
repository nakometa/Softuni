using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int avaiableFood = int.Parse(Console.ReadLine());
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(data);
            bool ordersComplete = true;

            Console.WriteLine(orders.Max());

            while (orders.Any())
            {
                if (avaiableFood >= orders.Peek())
                {
                    avaiableFood -= orders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {String.Join(" ", orders)}");
                    ordersComplete = false;
                    break;
                }
            }

            if (ordersComplete)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
