using System;

namespace _10.Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneLev = int.Parse(Console.ReadLine());
            int twoLev = int.Parse(Console.ReadLine());
            int fiveLev = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= oneLev; i++)
            {
                for (int p = 0; p <= twoLev; p++)
                {
                    for (int c = 0; c <= fiveLev; c++)
                    {
                        int currentSum = i * 1 + p * 2 + c * 5;
                        if (currentSum == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {p} * 2 lv. + {c} * 5 lv. = {sum} lv.");
                            currentSum = 0;
                        }
                    }

                }
            }
        }
    }
}
