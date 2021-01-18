using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var numb = number;

            var factorialSum = 0;

            while (number != 0)
            {
                var currentNumber = number % 10;
                number /= 10;
                var factorial = 1;

                for (int i = 1; i <= currentNumber; i++)
                {
                    factorial *= i;
                }
                factorialSum += factorial;
            }

            if (numb == factorialSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
