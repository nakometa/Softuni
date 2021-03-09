using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> integers = new Stack<int>(elements);

            for (int i = 0; i < input[1]; i++)
            {
                integers.Pop();
            }
            if (integers.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else if (integers.Count > 0)
            {
                int smallestNum = int.MaxValue;
                foreach (var item in integers)
                {
                    if (item < smallestNum)
                    {
                        smallestNum = item;
                    }
                }
                Console.WriteLine(smallestNum);
            }
            else
            {
                Console.WriteLine(0);        
            }
        }
    }
}
