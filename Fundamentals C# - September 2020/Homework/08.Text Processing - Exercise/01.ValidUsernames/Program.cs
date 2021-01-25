using System;
using System.Linq;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            foreach (var password in input)
            {
                if (password.Length >= 3 && password.Length <= 16)
                {
                    if (password.All(x => char.IsLetterOrDigit(x)) || password.Contains("_") || password.Contains("-"))
                    {
                        Console.WriteLine(password);
                    }
                }
            }
        }
    }
}
