using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                var student = Console.ReadLine().Split();
                var name = student[0];
                var grade = decimal.Parse(student[1]);

                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades.Add(name, new List<decimal>());
                    studentGrades[name].Add(grade);
                }
                else
                {
                    studentGrades[name].Add(grade);
                }
            }

            foreach (var student in studentGrades)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: {student.Value.Average():F2})");
            }
        }
    }
}
