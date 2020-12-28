using System;

namespace _09.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int c = 1;
            var sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(c);
                sum += c;
                c += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
