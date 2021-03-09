using System;
using System.Linq;

namespace _02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = n => int.Parse(n);
            int[] input = Console.ReadLine().Split(", ").Select(parser).ToArray();

            Console.WriteLine(input.Length);
            Console.WriteLine(input.Sum());
        }
    }
}
