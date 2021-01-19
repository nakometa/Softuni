using System;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");
            var bestCounter = 0;
            var bestIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                string currentNumber = arr[i];
                var currentCounter = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currentNumber == arr[j])
                    {
                        currentCounter += 1;
                    }
                    else
                    {
                        break;
                    }
                }
                if (bestCounter < currentCounter)
                {
                    bestCounter = currentCounter;
                    bestIndex = i;
                }
            }

            for (int i = 0; i <= bestCounter; i++)
            {
                Console.Write(arr[bestIndex] + " ");
            }
        }
    }
}
