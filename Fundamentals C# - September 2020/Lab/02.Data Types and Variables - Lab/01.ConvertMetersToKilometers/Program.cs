using System;

namespace _01.ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            decimal metersToKilometers = meters / 1000M;

            Console.WriteLine($"{metersToKilometers:F2}");
        }
    }
}
