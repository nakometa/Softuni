using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        List<T> items;

        public Box()
        {
            items = new List<T>();
        }

        public int Count { get => items.Count;}

        public void Add(T element)
        {
            items.Insert(0, element);
        }

        public T Remove()
        {
            var temp = items[0];
            items.RemoveAt(0);
            return temp;
        }
    }
}
