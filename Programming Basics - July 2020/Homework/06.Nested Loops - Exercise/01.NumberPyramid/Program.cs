using System;

namespace _01.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetNum = int.Parse(Console.ReadLine());
            int rows = 1;
            int currentNum = 0;
            bool isReached = false;

            for (int i = 1; i <= targetNum; i++)
            {
                for (int k = 1; k <= rows; k++)
                {
                    currentNum++;
                    Console.Write($"{currentNum} ");
                    if (currentNum == targetNum)
                    {
                        isReached = true;
                        break;
                    }
                }
                if (isReached)
                {
                    break;
                }
                rows++;
                Console.WriteLine();
            }
        }
    }
}
