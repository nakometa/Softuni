using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> addVat = n => n += n * 0.2;
            double[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Select(addVat).ToArray();

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item:F2}");
            }
        }
    }
}
