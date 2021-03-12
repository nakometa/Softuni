﻿using System;
using System.Linq;

namespace _08.CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Action<int[]> print = nums => Console.WriteLine(String.Join(" ", nums));

            Array.Sort(numbers, (a, b) =>
            {
                if (a % 2 == 0 && b % 2 != 0)
                {
                    return -1;
                }
                else if (a % 2 != 0 && b % 2 == 0)
                {
                    return 1;
                }
                return a.CompareTo(b);
            });

            print(numbers);
        }
    }
}