using System;

namespace _13.PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPairStart = int.Parse(Console.ReadLine());
            int secondPairStart = int.Parse(Console.ReadLine());
            int firstPairEnd = int.Parse(Console.ReadLine());
            int secondPairEnd = int.Parse(Console.ReadLine());

            for (int i = firstPairStart; i <= firstPairStart + firstPairEnd; i++)
            {
                for (int j = secondPairStart; j <= secondPairStart + secondPairEnd; j++)
                {
                    bool firstPairPrime = false;
                    bool secondPairPrime = false;
                    int counter1 = 0;
                    int counter2 = 0;
                    for (int b = 2; b <= i; b++)
                    {
                        if (i % b == 0)
                        {
                            counter2++;
                        }
                    }
                    if (counter2 < 2)
                    {
                        firstPairPrime = true;
                    }
                    for (int n = 2; n <= j; n++)
                    {
                        if (j % n == 0)
                        {
                            counter1++;
                        }
                    }
                    if (counter1 < 2)
                    {
                        secondPairPrime = true;
                    }
                    if (firstPairPrime && secondPairPrime)
                    {
                        Console.WriteLine($"{i}{j}");
                    }
                }
            }
        }
    }
}
