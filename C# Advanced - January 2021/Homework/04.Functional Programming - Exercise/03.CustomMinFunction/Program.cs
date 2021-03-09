using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> smallestNum = SmallestInt;
            Console.WriteLine(smallestNum(input));
        }

        private static int SmallestInt(int[] numbers)
        {
            int minInt = int.MaxValue;
            foreach (var currentNum in numbers)
            {
                if (currentNum < minInt)
                {
                    minInt = currentNum;
                }
            }
            return minInt;
        }
    }
}
