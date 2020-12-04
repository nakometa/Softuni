using System;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minimalWage = double.Parse(Console.ReadLine());

            //Calculations
            double socialScholarship = Math.Floor(minimalWage * 0.35);
            double excellentScholarship = Math.Floor(averageGrade * 25);

            //Output
            if (income >= minimalWage && averageGrade >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellentScholarship} BGN");
            }
            else if (income >= minimalWage && averageGrade < 5.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (income < minimalWage && averageGrade >= 5.5 && socialScholarship <= excellentScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellentScholarship} BGN");
            }
            else if (income < minimalWage && averageGrade > 4.5)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else if (income < minimalWage && averageGrade <= 4.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
