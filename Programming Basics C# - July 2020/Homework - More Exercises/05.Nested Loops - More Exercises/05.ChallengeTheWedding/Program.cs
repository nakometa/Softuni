using System;

namespace _05.ChallengeTheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int man = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int maxTables = int.Parse(Console.ReadLine());
            bool freeSpace = false;

            for (int i = 1; i <= man; i++)
            {
                for (int k = 1; k <= women; k++)
                {
                    if (maxTables <= 0)
                    {
                        freeSpace = true;
                        break;
                    }
                    Console.Write($"({i} <-> {k}) ");
                    maxTables--;
                }
                if (freeSpace)
                {
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
