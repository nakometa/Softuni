using System;

namespace _04.CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());
            bool evenStart = false;
            bool oddStart = false;
            bool evenFinish = false;
            bool oddFinish = false;
            bool isFirstDigitBiggerThanLast = false;
            bool isSecondAndThirdDigitSumEven = false;

            for (int i = start; i <= finish; i++)
            {
                for (int k = start; k <= finish; k++)
                {
                    for (int m = start; m <= finish; m++)
                    {
                        for (int c = start; c <= finish; c++)
                        {
                            int km = k + m;
                            if (i % 2 == 0)
                            {
                                evenStart = true;
                            }
                            else
                            {
                                oddStart = true;
                            }
                            if (c % 2 == 0)
                            {
                                evenFinish = true;
                            }
                            else
                            {
                                oddFinish = true;
                            }
                            if (i > c)
                            {
                                isFirstDigitBiggerThanLast = true;
                            }
                            if (km % 2 == 0)
                            {
                                isSecondAndThirdDigitSumEven = true;
                            }
                            if (evenStart && oddFinish && isFirstDigitBiggerThanLast && isSecondAndThirdDigitSumEven)
                            {
                                Console.Write($"{i}{k}{m}{c} ");
                            }
                            else if (oddStart && evenFinish && isFirstDigitBiggerThanLast && isSecondAndThirdDigitSumEven)
                            {
                                Console.Write($"{i}{k}{m}{c} ");
                            }
                            evenStart = false;
                            oddStart = false;
                            evenFinish = false;
                            oddFinish = false;
                            isFirstDigitBiggerThanLast = false;
                            isSecondAndThirdDigitSumEven = false;
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
