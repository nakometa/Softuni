using System;

namespace _10.WeatherForecast_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());

            if (celsius >= 5.00 && celsius <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else if (celsius >= 12 && celsius <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (celsius >= 15 && celsius <= 20.00)
            {
                Console.WriteLine("Mild");
            }
            else if (celsius >= 20.1 && celsius <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (celsius >= 26 && celsius <= 35.00)
            {
                Console.WriteLine("Hot");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
