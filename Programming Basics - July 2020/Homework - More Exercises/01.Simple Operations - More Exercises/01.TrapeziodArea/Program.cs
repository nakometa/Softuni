using System;

namespace _01.TrapeziodArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double formula = (b1 + b2) * h / 2;
            Console.WriteLine("{0:0.00}", formula);
        }
    }
}
