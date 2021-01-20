using System;

namespace _07.NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            GenerateMatrix(input);
        }

        private static void GenerateMatrix(int matrixLength)
        {
            for (int i = 0; i < matrixLength; i++)
            {
                for (int j = 0; j < matrixLength; j++)
                {
                    Console.Write(matrixLength + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
