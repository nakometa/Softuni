using System;

namespace _03.CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double celsiusToFarenheit = celsius * 9 / 5 + 32;

            Console.WriteLine("{0:0.00}", celsiusToFarenheit);
        }
    }
}
