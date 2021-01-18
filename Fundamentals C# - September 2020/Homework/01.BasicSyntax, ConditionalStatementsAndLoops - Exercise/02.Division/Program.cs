using System;

namespace _02.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var type = "";

            if (number % 10 == 0)
            {
                type = "The number is divisible by 10";
            }
            else if (number % 7 == 0)
            {
                type = "The number is divisible by 7";
            }
            else if (number % 6 == 0)
            {
                type = "The number is divisible by 6";
            }
            else if (number % 3 == 0)
            {
                type = "The number is divisible by 3";
            }
            else if (number % 2 == 0)
            {
                type = "The number is divisible by 2";
            }
            else
            {
                type = "Not divisible";
            }

            Console.WriteLine(type);
        }
    }
}
