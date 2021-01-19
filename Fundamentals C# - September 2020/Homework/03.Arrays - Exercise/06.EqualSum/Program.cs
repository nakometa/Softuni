using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            bool valid = false;

            for (int curr = 0; curr < arr.Length; curr++)
            {
                var rightSum = 0;
                for (int i = curr + 1; i < arr.Length; i++)
                {
                    rightSum += arr[i];
                }
                var leftSum = 0;
                for (int i = curr - 1; i >= 0; i--)
                {
                    leftSum += arr[i];
                }

                if (rightSum == leftSum)
                {
                    valid = true;
                    Console.WriteLine(curr);
                }
            }
            if (!valid)
            {
                Console.WriteLine("no");
            }
        }
    }
}
