using System;

namespace _09.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double leftSum = 0;
            double rightSum = 0;

            for (int i = 0; i < n * 2; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i < n)
                {
                    leftSum += number;
                }
                else
                {
                    rightSum += number;
                }
            }
            if (rightSum == leftSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {

                Console.WriteLine($"No, diff = {Math.Abs(rightSum - leftSum)}");
            }
        }
    }
}
