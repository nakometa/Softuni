using System;

namespace _06.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double formula = a * a;
                Console.WriteLine($"{formula:F3}");
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double formula = a * b;
                Console.WriteLine($"{formula:F3}");
            }
            else if (figure == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                double squareOfTheRadius = a * a;
                double formula = squareOfTheRadius * Math.PI;
                Console.WriteLine($"{formula:F3}");
            }
            else if (figure == "triangle")
            {
                double h = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double formula = h * b / 2;
                Console.WriteLine($"{formula:F3}");
            }
        }
    }
}
