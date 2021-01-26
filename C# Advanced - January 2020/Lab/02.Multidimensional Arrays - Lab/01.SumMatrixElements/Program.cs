using System;
using System.Linq;

namespace _01.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[input[0],input[1]];
            int sum = 0;

            for (int rows = 0; rows < input[0]; rows++)
            {
                int[] elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < input[1]; col++)
                {
                    sum += elements[col];
                }
            }

            Console.WriteLine($"{input[0]}\n{input[1]}\n{sum}");
        }
    }
}
