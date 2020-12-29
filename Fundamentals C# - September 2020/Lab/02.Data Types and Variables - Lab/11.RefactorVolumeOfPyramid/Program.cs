using System;

namespace _11.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            decimal length = decimal.Parse(Console.ReadLine());
            Console.Write("Width: ");
            decimal width = decimal.Parse(Console.ReadLine());
            Console.Write("Height: ");
            decimal height = decimal.Parse(Console.ReadLine());
            decimal V = (length * width * height) / 3;
            Console.WriteLine($"Pyramid Volume: {V:f2}");
        }
    }
}
