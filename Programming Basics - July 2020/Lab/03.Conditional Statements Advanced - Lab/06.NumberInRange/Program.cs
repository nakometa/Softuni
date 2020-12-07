using System;

namespace _06.NumberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number >= -100 && number <= 100)
            {
                if (number == 0)
                {
                    Console.WriteLine("No");
                }
                else
                {
                    Console.WriteLine("Yes");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
