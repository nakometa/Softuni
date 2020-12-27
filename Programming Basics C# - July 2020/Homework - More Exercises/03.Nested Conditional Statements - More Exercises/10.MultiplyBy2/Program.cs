using System;

namespace _10.MultiplyBy2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double i = double.Parse(Console.ReadLine()); i >= 0;)
            {
                i = i * 2;
                Console.WriteLine($"Result: {i:F2}");
                i = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Negative number!");
        }
    }
}
