using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Func<string, bool> func = name => name.Length <= n;
            Console.WriteLine(String.Join("\n", names.Where(func)));
        }
    }
}
