using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintAllTopNumbers(input);
        }

        private static void PrintAllTopNumbers(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                bool isDivisibleBy8 = false;
                bool containsOddDigit = false;
                int num = i;
                int sumOfNumbers = 0;
                while (num > 0)
                {
                    int currentNum = num % 10;
                    if (currentNum % 2 == 1)
                    {
                        containsOddDigit = true;
                    }
                    sumOfNumbers += currentNum;
                    num /= 10;
                }
                if (sumOfNumbers % 8 == 0)
                {
                    isDivisibleBy8 = true;
                }
                if (isDivisibleBy8 && containsOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
