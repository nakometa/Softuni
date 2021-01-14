using System;
using System.Linq;

namespace _05.WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string[] evenLengthWords = input.Where(n => n.Length % 2 == 0).ToArray();

            foreach (var word in evenLengthWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
