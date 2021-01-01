using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine(AreaCalculator(width, height));
        }

        static int AreaCalculator(int width, int height)
        {
            int area = width * height;
            return area;
        }
    }
}
