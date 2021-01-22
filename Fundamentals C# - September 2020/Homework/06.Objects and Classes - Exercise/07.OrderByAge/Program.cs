using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<Person> people = new List<Person>();

            while (input[0] != "End")
            {
                Person currentPerson = new Person(input[0], input[1], int.Parse(input[2]));
                people.Add(currentPerson);
                input = Console.ReadLine().Split();
            }

            foreach (var person in people.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }

    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
