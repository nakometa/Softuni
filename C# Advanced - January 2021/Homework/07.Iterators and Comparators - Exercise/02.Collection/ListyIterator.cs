using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _02.Collection
{
    public class ListyIterator <T> : IEnumerable<T>
    {
        private List<T> items;
        private int index;

        public ListyIterator(List<T> items)
        {
            this.items = items;
            index = 0;
        }

        public void Print()
        {
            if (index >= this.items.Count)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(this.items[index]);
        }

        public bool HasNext() => this.index < this.items.Count - 1;

        public bool Move()
        {
            bool hasNext = this.HasNext();

            if (hasNext)
            {
                this.index++;
            }
            return hasNext;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in this.items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
