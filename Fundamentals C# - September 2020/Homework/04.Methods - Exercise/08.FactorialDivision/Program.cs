using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            float int1 = float.Parse(Console.ReadLine());
            float int2 = float.Parse(Console.ReadLine());
            float factorialDivision = CalculateFactorialAndDivide(int1, int2);
            Console.WriteLine($"{factorialDivision:F2}");
        }

        private static float CalculateFactorialAndDivide(float int1, float int2)
        {
            for (float i = int1 - 1; i >= 1; i--)
            {
                int1 = int1 * i;
            }
            for (float i = int2 - 1; i >= 1; i--)
            {
                int2 = int2 * i;
            }
            float division = int1 / int2;
            return division;
        }
    }
}
