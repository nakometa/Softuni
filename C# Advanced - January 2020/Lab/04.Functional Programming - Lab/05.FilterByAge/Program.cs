using System;

namespace _05.FilterByAge
{
    class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            People[] people = new People[n];
            for (int i = 0; i < n; i++)
            {
                var person = Console.ReadLine().Split(", ");
                people[i] = new People();
                people[i].Name = person[0];
                people[i].Age = int.Parse(person[1]);
            }
            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            Func<People, bool> conditionChecker = CheckCondition(condition, age);
            var format = Console.ReadLine();
            Func<People, string> formatChcker = CheckFormat(format, people);

            PrintStudents(people, conditionChecker, formatChcker);
        }

        private static Func<People, string> CheckFormat(string format, People[] people)
        {
            switch (format)
            {
                case "name": return s => $"{s.Name}";
                case "age": return s => $"{s.Age}";
                case "name age": return s => $"{s.Name} - {s.Age}";
                default: return null;
            }
        }

        private static Func<People, bool> CheckCondition(string condition, int age)
        {
            switch (condition)
            {
                case "younger": return x => x.Age < age;
                case "older": return x => x.Age >= age;
                default:  return null;

            }
        }

        private static void PrintStudents(People[] people, Func<People, bool> conditionChecker, Func<People, string> formatChcker)
        {
            foreach (var item in people)
            {
                if (conditionChecker(item))
                {
                    Console.WriteLine(formatChcker(item));
                }
            }
        }
    }
}
