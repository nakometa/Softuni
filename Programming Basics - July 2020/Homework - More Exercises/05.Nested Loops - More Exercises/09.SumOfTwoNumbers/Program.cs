using System;

namespace _09.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isFound = false;
            int firstNum = 0;
            int secondsNum = 0;

            for (int i = start; i <= end; i++)
            {
                for (int p = start; p <= end; p++)
                {
                    counter++;
                    if (i + p == magicNum)
                    {
                        firstNum = i;
                        secondsNum = p;
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }

            if (isFound)
            {
                Console.WriteLine($"Combination N:{counter} ({firstNum} + {secondsNum} = {magicNum})");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
        }
    }
}
