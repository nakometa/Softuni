using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] boundaries = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> numbers = new List<int>();

            for (int i = boundaries[0]; i <= boundaries[1]; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> predicate = n => true;
            string predicateType = Console.ReadLine();
            if (predicateType == "odd")
            {
                predicate = n => n % 2 != 0;
            }
            else
            {
                predicate = n => n % 2 == 0;
            }
            Console.WriteLine(String.Join(" ", OrderList(numbers, predicate)));
        }

        private static List<int> OrderList(List<int> numbers, Predicate<int> predicate)
        {
            List<int> newList = new List<int>();
            foreach (var item in numbers)
            {
                if (predicate(item))
                {
                    newList.Add(item);
                }
            }
            return newList;
        }
    }
}