using System;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

            var evenSum = 0;
            var oddSum = 0;

            foreach (var item in arr)
            {
                if (item % 2 == 0)
                {
                    evenSum += item;
                }
                else
                {
                    oddSum += item;
                }
            }
            Console.WriteLine(evenSum - oddSum);
        }
    }
}
