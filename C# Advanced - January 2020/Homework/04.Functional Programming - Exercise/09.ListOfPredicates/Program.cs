using System;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int, int, bool> func = (num, d) => num % d == 0;

            for (int i = 1; i <= n; i++)
            {
                if (dividers.All(d => func(i, d)))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
