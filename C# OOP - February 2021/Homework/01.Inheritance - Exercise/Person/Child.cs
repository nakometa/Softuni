using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Child : Person
    {
        public Child(string name, int age) : 
            base(name, age)
        {

        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
