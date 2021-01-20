using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1 = int.Parse(Console.ReadLine());
            int int2 = int.Parse(Console.ReadLine());
            int int3 = int.Parse(Console.ReadLine());

            int result = AddFirstToSecondInt(int1, int2, int3);
            Console.WriteLine(result);
        }

        public static int AddFirstToSecondInt(int int1, int int2, int int3)
        {
            int result = int1 + int2;
            int subtract = SubtractResultFromThirdInt(result, int3);
            return subtract;
        }

        private static int SubtractResultFromThirdInt(int result, int int3)
        {
            int subtract = result - int3;
            return subtract;
        }
    }
}
