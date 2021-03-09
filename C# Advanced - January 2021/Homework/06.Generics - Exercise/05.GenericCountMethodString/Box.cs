using System;
using System.Collections.Generic;
using System.Text;

namespace _05.GenericCountMethodString
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
