using System;

namespace _02.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal britishPounds = decimal.Parse(Console.ReadLine());
            decimal poundsToUsd = britishPounds * 1.31M;

            Console.WriteLine($"{poundsToUsd:F3}");
        }
    }
}
