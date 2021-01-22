using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < amountOfStudents; i++)
            {
                string[] data = Console.ReadLine().Split();
                Student currentStudent = new Student(data[0], data[1], double.Parse(data[2]));
                students.Add(currentStudent);
            }
            students = students.OrderByDescending(a => a.Grade).ToList();

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }
}
