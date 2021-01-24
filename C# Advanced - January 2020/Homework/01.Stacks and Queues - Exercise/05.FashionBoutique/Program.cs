using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> clothes = new Stack<int>(input);
            int rackCapacity = int.Parse(Console.ReadLine());
            int currentRack = rackCapacity;
            int racksUsed = 1;

            while (clothes.Any())
            {
                int currentCloth = clothes.Pop();
                currentRack -= currentCloth;

                if (currentRack < 0)
                {
                    racksUsed++;
                    currentRack = rackCapacity - currentCloth;
                }
            }
            Console.WriteLine(racksUsed);
        }
    }
}
