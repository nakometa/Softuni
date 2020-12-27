using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorGradesAccepted = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int failCounter = 0;
            int problemsCounter = 0;
            int sum = 0;
            bool isFailed = false;
            string lastProblem = null;
            int totalGrades = 0;

            while (input != "Enough")
            {
                int currentGrade = int.Parse(Console.ReadLine());
                totalGrades++;
                sum += currentGrade;
                lastProblem = input;

                if (currentGrade <= 4)
                {
                    failCounter++;
                    if (failCounter >= poorGradesAccepted)
                    {
                        isFailed = true;
                        break;
                    }
                }
                input = Console.ReadLine();
                problemsCounter++;
            }
            if (!isFailed)
            {
                Console.WriteLine($"Average score: {sum * 1.0 / totalGrades:F2}");
                Console.WriteLine($"Number of problems: {problemsCounter}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {failCounter} poor grades.");
            }
        }
    }
}
