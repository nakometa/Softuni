using System;

namespace _07.Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstTupleData = Console.ReadLine().Split();
            MyTuple<string, string> firstTuple = new MyTuple<string, string>($"{firstTupleData[0]} {firstTupleData[1]}", firstTupleData[2]);
            Console.WriteLine(firstTuple.ToString());

            string[] secondTupleData = Console.ReadLine().Split();
            MyTuple<string, int> secondTuple = new MyTuple<string, int>(secondTupleData[0], int.Parse(secondTupleData[1]));
            Console.WriteLine(secondTuple.ToString());

            string[] thirdTupleData = Console.ReadLine().Split();
            MyTuple<int, double> thirdTuple = new MyTuple<int, double>(int.Parse(thirdTupleData[0]), double.Parse(thirdTupleData[1]));
            Console.WriteLine(thirdTuple.ToString());
        }
    }
}
