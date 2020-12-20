using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string presentationName = Console.ReadLine();
            int counter = 0;
            double totalGrade = 0;
            double totalCounter = 0;

            while (presentationName != "Finish")
            {
                int lectors = int.Parse(input);
                double currentAverage = 0;
                for (int i = 0; i < lectors; i++)
                {
                    double currentGrade = double.Parse(Console.ReadLine());
                    currentAverage += currentGrade;
                    counter++;
                    totalGrade += currentGrade;
                    totalCounter++;
                }
                Console.WriteLine($"{presentationName} - {currentAverage / lectors:F2}.");
                presentationName = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {totalGrade / totalCounter:F2}.");
        }
    }
}
