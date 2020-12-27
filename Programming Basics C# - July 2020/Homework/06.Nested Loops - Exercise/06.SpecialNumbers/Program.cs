using System;

namespace _06.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int p = 1; p <= 9; p++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (n % i == 0 && n % p == 0 && n % c == 0 && n % d == 0)
                            {
                                Console.Write($"{i}{p}{c}{d}" + " ");
                            }
                        }
                    }
                }
            }
        }
    }
}
