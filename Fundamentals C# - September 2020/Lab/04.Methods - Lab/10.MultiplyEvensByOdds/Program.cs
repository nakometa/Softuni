using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            string num = number.ToString();
            int multiply = SplitEvensAndOdds(num);
            Console.WriteLine(multiply);
        }

        static int SplitEvensAndOdds(string number)
        {
            int evenSum = 0;
            int oddSum = 0;
            foreach (var item in number)
            {
                int currentNum = item - '0';
                if (item % 2 == 0)
                {
                    evenSum += currentNum;
                }
                else
                {
                    oddSum += currentNum;
                }
            }
            int multiply = evenSum * oddSum;
            return multiply;
        }
    }
}
