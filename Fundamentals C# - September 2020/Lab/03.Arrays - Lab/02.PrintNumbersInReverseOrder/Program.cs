using System;

namespace _02.PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            //
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                numbers[i] = num;
            }
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
