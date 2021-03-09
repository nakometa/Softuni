using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Tuple
{
    class MyTuple<T1,T2>
    {
        public MyTuple(T1 Item1, T2 Item2)
        {
            this.Item1 = Item1;
            this.Item2 = Item2;
        }

        public T1 Item1 { get; set; }

        public T2 Item2 { get; set; }

        public override string ToString()
        {
            return $"{Item1} -> {Item2}";
        }
    }
}
