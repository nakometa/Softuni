using System;

namespace _02.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int count = 1;

            for (int i = start; i <= end; i++)
            {
                int currentNum = i;
                int evenSum = 0;
                int oddSum = 0;

                while (currentNum != 0)
                {
                    int currentDigit = currentNum % 10;
                    if (count % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }
                    currentNum = currentNum / 10;
                    count++;
                }
                count = 1;
                if (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
