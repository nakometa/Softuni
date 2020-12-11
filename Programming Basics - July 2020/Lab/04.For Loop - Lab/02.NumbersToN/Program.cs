using System;

namespace _02.NumbersToN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; n--)
            {
                Console.WriteLine(n);
            }
        }
    }
}
