using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            numbers.Reverse();
            Func<int, bool> predicate = num => num % n != 0;
            Console.WriteLine(String.Join(" ",numbers.Where(predicate)));
        }
    }
}