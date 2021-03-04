using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _06.EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override int GetHashCode()
        {
            int nameHash = this.Name.GetHashCode();
            int ageHash = this.Age.GetHashCode();
            return nameHash + ageHash;
        }

        public int CompareTo(Person other)
        {
            return this.GetHashCode().CompareTo(other.GetHashCode());
        }
    }
}
