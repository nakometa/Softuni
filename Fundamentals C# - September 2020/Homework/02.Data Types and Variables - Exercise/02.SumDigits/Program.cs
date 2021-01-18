using System;

namespace _02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();
            var sum = 0;
            //
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i] - '0';
            }
            Console.WriteLine(sum);
        }
    }
}
