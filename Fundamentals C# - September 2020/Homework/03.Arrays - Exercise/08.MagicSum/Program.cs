using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var magicNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                var firstNumber = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    var secondNumber = arr[j];
                    if (firstNumber + secondNumber == magicNumber)
                    {
                        Console.WriteLine($"{firstNumber} {secondNumber}");
                    }
                }

            }
        }
    }
}
