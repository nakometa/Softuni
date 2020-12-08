using System;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string porjectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double roomLength = rows * columns;
            double income = 0;
            if (porjectionType == "Premiere")
            {
                income += roomLength * 12;
            }
            else if (porjectionType == "Normal")
            {
                income += roomLength * 7.5;
            }
            else
            {
                income += roomLength * 5;
            }

            Console.WriteLine($"{income:F2} leva");
        }
    }
}
