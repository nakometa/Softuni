using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string[] cmdArgs = Console.ReadLine().Split();
            int match = 0;
            int diff = 0;

            while (cmdArgs[0] != "END")
            {
                people.Add(new Person(cmdArgs[0], int.Parse(cmdArgs[1]), cmdArgs[2]));
                cmdArgs = Console.ReadLine().Split();
            }
            int personIndex = int.Parse(Console.ReadLine()) - 1;
            var person = people[personIndex];

            foreach (var item in people)
            {
                int result = item.CompareTo(person);
                if (result == 0)
                {
                    match++;
                }
                else
                {
                    diff++;
                }
            }

            string output = match > 1 ? $"{match} {diff} {people.Count}" : "No matches";
            Console.WriteLine(output);
        }
    }
}
