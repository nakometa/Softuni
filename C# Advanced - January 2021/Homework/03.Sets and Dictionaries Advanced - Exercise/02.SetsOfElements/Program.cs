using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstSetLength = n[0];
            int secondSetLength = n[1];
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < firstSetLength; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }
            for (int i = 0; i < secondSetLength; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondSet.Add(number);
            }

            Console.WriteLine(String.Join(" ", firstSet.Where(x => secondSet.Contains(x))));
        }
    }
}
