using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.EqualityLogic
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<Person> peopleSet = new SortedSet<Person>();
            HashSet<Person> peopleHash = new HashSet<Person>();


            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                Person currentPerson = new Person(cmdArgs[0], int.Parse(cmdArgs[1]));
                peopleHash.Add(currentPerson);
                bool valid = false;
                foreach (var item in peopleSet)
                {
                    int result = currentPerson.CompareTo(item);
                    if (result == 0)
                    {
                        valid = true;
                    }
                }
                if (!valid)
                {
                    peopleSet.Add(currentPerson);
                }
            }

            Console.WriteLine($"{peopleSet.Count} {peopleHash.Count}");
        }
    }
}
