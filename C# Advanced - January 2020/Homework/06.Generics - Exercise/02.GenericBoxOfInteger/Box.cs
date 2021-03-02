using System;
using System.Collections.Generic;
using System.Text;

namespace _02.GenericBoxOfInteger
{
    public class Box <T>
    {
        public Box(T value)
        {
            this.value = value;
        }

        public T value { get; set; }

        public override string ToString()
        {
            Type currentType = this.value.GetType();
            string typeName = currentType.FullName;
            return $"{typeName}: {value}";
        }
    }
}
