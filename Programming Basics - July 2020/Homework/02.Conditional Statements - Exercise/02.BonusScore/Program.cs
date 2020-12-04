using System;

namespace _02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            double bonusPoints = 0.0;

            if (inputNumber <= 100)
            {
                bonusPoints += 5;
            }
            else if (inputNumber <= 1000)
            {
                bonusPoints = inputNumber * 0.2;
            }
            else if (inputNumber > 1000)
            {
                bonusPoints = inputNumber * 0.1;
            }

            if (inputNumber % 2 == 0)
            {
                bonusPoints += 1;
            }
            else if (inputNumber % 10 == 5)
            {
                bonusPoints += 2;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(inputNumber + bonusPoints);
        }
    }
}
