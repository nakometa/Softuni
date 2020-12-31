using System;
using System.Linq;

namespace _07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var different = false;
            var sum = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                sum += arr1[i];
                if (arr1[i] != arr2[i])
                {
                    different = true;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
            }
            if (!different)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
