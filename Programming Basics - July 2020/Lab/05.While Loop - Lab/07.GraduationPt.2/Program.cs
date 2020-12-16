using System;

namespace _07.GraduationPt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double totalGrade = 0;
            int i = 1;
            int excludedCounter = 0;

            while (i < 13)
            {
                if (excludedCounter > 1)
                {
                    Console.WriteLine($"{name} has been excluded at {i} grade");
                    break;
                }
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4)
                {
                    excludedCounter++;
                    continue;
                }

                totalGrade += grade;
                i++;
            }
            if (excludedCounter < 2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {totalGrade / 12:F2}");
            }
        }
    }
}
