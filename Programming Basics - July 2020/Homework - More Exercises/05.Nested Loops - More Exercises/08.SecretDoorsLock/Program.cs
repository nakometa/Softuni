using System;

namespace _08.SecretDoorsLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int limitI = int.Parse(Console.ReadLine());
            int limitJ = int.Parse(Console.ReadLine());
            int limitK = int.Parse(Console.ReadLine());

            for (int i = 2; i <= limitI; i += 2)
            {
                for (int j = 2; j <= limitJ; j++)
                {
                    for (int k = 2; k <= limitK; k += 2)
                    {
                        if (j != 4 && j != 6 && j <= 7)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}
