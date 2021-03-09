using System;
using System.Collections.Generic;
using System.Text;

namespace _01.GenericBoxOfString
{
    public class Box <T>
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
