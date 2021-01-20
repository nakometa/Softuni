using System;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            ReturnSmallestNumber(firstNumber, secondNumber, thirdNumber);
        }

        private static void ReturnSmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            int smallestNum = 0;
            if (firstNumber < secondNumber && firstNumber < thirdNumber)
            {
                smallestNum = firstNumber;
            }
            else if (secondNumber < firstNumber && secondNumber < thirdNumber)
            {
                smallestNum = secondNumber;
            }
            else
            {
                smallestNum = thirdNumber;
            }
            Console.WriteLine(smallestNum);
        }
    }
}
