using System;
using System.Collections.Generic;
using System.Text;

namespace _04.GenericSwapMethodInteger
{
    public class Box <T>
    {
        public Box(T value)
        {
            this.value = value;
        }

        public T value;

        public static void SwapIndexes (List<Box<T>> boxes, int firstIndex, int secondIndex)
        {
            var temp = boxes[firstIndex];
            boxes[firstIndex] = boxes[secondIndex];
            boxes[secondIndex] = temp;
        }
        public override string ToString()
        {
            Type currentType = value.GetType();
            string typeName = currentType.FullName;
            return $"{typeName}: {value}";
        }
    }
}
