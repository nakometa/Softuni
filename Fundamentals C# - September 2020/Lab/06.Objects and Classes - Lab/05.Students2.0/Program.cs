using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Students2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentInformation = Console.ReadLine().Split();
            List<Student> studentsList = new List<Student>();

            while (studentInformation[0] != "end")
            {
                Student checkStudent = studentsList.FirstOrDefault(s => s.FirstName == studentInformation[0] && s.LastName == studentInformation[1]);
                if (checkStudent == null)
                {
                    Student student = new Student();
                    student.FirstName = studentInformation[0];
                    student.LastName = studentInformation[1];
                    student.Age = studentInformation[2];
                    student.HomeTown = studentInformation[3];
                    studentsList.Add(student);
                }
                else
                {
                    checkStudent.FirstName = studentInformation[0];
                    checkStudent.LastName = studentInformation[1];
                    checkStudent.Age = studentInformation[2];
                    checkStudent.HomeTown = studentInformation[3];
                }
                studentInformation = Console.ReadLine().Split();
            }
            string city = Console.ReadLine();

            foreach (Student student in studentsList)
            {
                if (city == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Age { get; set; }
            public string HomeTown { get; set; }
        }
    }
}
