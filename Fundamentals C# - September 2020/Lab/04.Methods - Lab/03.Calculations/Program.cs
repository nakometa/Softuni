using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (operation == "add")
            {
                Increment(num1, num2);
            }
            else if (operation == "multiply")
            {
                Multiply(num1, num2);
            }
            else if (operation == "subtract")
            {
                Subtract(num1, num2);
            }
            else if (operation == "divide")
            {
                Divide(num1, num2);
            }
        }

        static void Increment(int numberOne, int numberTwo)
        {
            int result = numberOne + numberTwo;
            Console.WriteLine(result);
        }

        static void Subtract(int numberOne, int numberTwo)
        {
            int result = numberOne - numberTwo;
            Console.WriteLine(result);
        }

        static void Multiply(int numberOne, int numberTwo)
        {
            int result = numberOne * numberTwo;
            Console.WriteLine(result);
        }

        static void Divide(int numberOne, int numberTwo)
        {
            int result = numberOne / numberTwo;
            Console.WriteLine(result);
        }
    }
}
