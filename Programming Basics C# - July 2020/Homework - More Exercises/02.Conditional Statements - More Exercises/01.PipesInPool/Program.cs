using System;

namespace _01.PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int volume = int.Parse(Console.ReadLine());
            int firstPipe = int.Parse(Console.ReadLine());
            int secondPipe = int.Parse(Console.ReadLine());
            double hoursMissing = double.Parse(Console.ReadLine());

            //Calculations
            double firstPipeTotal = firstPipe * hoursMissing;
            double secondPipeTotal = secondPipe * hoursMissing;
            double totalLiters = firstPipeTotal + secondPipeTotal;

            double totalPercent = (totalLiters / volume) * 100;

            //Output
            if (volume >= totalLiters)
            {
                double firstPipePercent = (firstPipeTotal / totalLiters) * 100;
                double secondPipePercent = (secondPipeTotal / totalLiters) * 100;
                Console.WriteLine($"The pool is {totalPercent:F2}% full. Pipe 1: {firstPipePercent:F2}%. Pipe 2: {secondPipePercent}%.");
            }
            else
            {
                double overflow = totalLiters - volume;
                Console.WriteLine($"For {hoursMissing:F2} hours the pool overflows with {overflow:F2} liters.");
            }
        }
    }
}
