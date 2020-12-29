using System;

namespace _07.ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string sign = Console.ReadLine();

            Console.WriteLine($"{firstName}{sign}{secondName}");
        }
    }
}
