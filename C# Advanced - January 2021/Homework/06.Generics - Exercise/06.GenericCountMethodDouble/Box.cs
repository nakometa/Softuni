using System;
using System.Collections.Generic;
using System.Text;

namespace _06.GenericCountMethodDouble
{
    public class Box <T>
        where T : IComparable
    {
        public Box(T value)
        {
            this.value = value;
        }

        public T value;

        public override string ToString()
        {
            Type currentType = value.GetType();
            string typeName = currentType.FullName;
            return $"{typeName}: {value}";
        }
    }
}
