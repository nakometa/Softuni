using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            if (input == "mm" && output == "cm")
            {
                number /= 10;
            }
            else if (input == "mm" && output == "m")
            {
                number /= 1000;
            }
            else if (input == "cm" && output == "mm")
            {
                number *= 10;
            }
            else if (input == "cm" && output == "m")
            {
                number /= 100;
            }
            else if (input == "m" && output == "cm")
            {
                number *= 100;
            }
            else if (input == "m" && output == "mm")
            {
                number *= 1000;
            }
            Console.WriteLine($"{number:F3}");
        }
    }
}
