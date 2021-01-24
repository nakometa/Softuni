using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            Dictionary<string, double> sorted = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>() { grade });
                }
                else
                {
                    students[name].Add(grade);
                }
            }

            foreach (var student in students)
            {
                double grade = student.Value.Sum() / student.Value.Count;
                sorted.Add(student.Key, grade);
            }
            foreach (var student in sorted.OrderByDescending(x => x.Value).Where(x => x.Value >= 4.50))
            {
                Console.WriteLine($"{student.Key} -> {student.Value:F2}");
            }
        }
    }
}
