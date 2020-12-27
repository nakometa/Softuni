using System;

namespace _08.CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * Math.Pow(r, 2);
            double roundPerimeter = 2 * Math.PI * r;

            Console.WriteLine("{0:0.00}", circleArea);
            Console.WriteLine("{0:0.00}", roundPerimeter);
        }
    }
}
