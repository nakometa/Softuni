using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());
            double num = PowNumber(number, pow);
            Console.WriteLine(num);
        }

        static double PowNumber(double number, double pow)
        {
            double poweredNumber = Math.Pow(number, pow);
            return poweredNumber;
        }
    }
}
