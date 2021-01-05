using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> secondNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(numbers.Count, secondNumbers.Count); i++)
            {
                result.Add(numbers[i]);
                result.Add(secondNumbers[i]);
            }

            for (int i = Math.Min(numbers.Count, secondNumbers.Count); i < Math.Max(numbers.Count, secondNumbers.Count); i++)
            {
                if (i >= numbers.Count)
                {
                    result.Add(secondNumbers[i]);
                }
                else
                {
                    result.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
