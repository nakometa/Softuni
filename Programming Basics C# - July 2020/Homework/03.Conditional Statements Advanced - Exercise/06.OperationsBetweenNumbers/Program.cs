using System;

namespace _06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            double result = 0;

            if (symbol == "+")
            {
                result = N1 + N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {N1 + N2} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {N1 + N2} - odd");
                }

            }
            else if (symbol == "-")
            {
                result = N1 - N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {result} - odd");
                }
            }
            else if (symbol == "*")
            {
                result = N1 * N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {result} - odd");
                }
            }
            else if (symbol == "/" && N1 > 0 && N2 > 0)
            {
                result = N1 / N2;
                Console.WriteLine($"{N1} {symbol} {N2} = {result:F2}");
            }
            else if (symbol == "%" && N1 > 0 && N2 > 0)
            {
                result = N1 % N2;
                Console.WriteLine($"{N1} {symbol} {N2} = {result}");
            }
            else
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
            }
        }
    }
}
