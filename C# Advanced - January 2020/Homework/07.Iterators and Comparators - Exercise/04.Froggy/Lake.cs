using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> rocks;

        public Lake(List<int> rocks)
        {
            this.rocks = rocks;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.rocks.Count; i+=2)
            {
                yield return this.rocks[i];
            }

            int index = this.rocks.Count - 1;

            if (index % 2 == 0)
            {
                index--;
            }

            for (int i = index; i >= 0; i-=2)
            {
                yield return this.rocks[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
