using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double secondNum = double.Parse(Console.ReadLine());
            double result = Calculate(firstNum, operation, secondNum);
            Console.WriteLine(result);
        }

        static double Calculate(double firstNum, string operation, double secondNum)
        {
            double result = 0;
            switch (operation)
            {
                case "/":
                    result = firstNum / secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
            }
            return result;
        }
    }
}
