using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstTupleData = Console.ReadLine().Split();
            List<string> townData = firstTupleData.ToList().Skip(3).ToList();
            string town = string.Join(" ", townData);
            MyTuple<string, string, string> firstTuple = new MyTuple<string, string, string>($"{firstTupleData[0]} {firstTupleData[1]}", firstTupleData[2], town);
            Console.WriteLine(firstTuple.ToString());

            string[] secondTupleData = Console.ReadLine().Split();
            bool isDrunk = secondTupleData[2] == "drunk";
            MyTuple<string, int, bool> secondTuple = new MyTuple<string, int, bool>(secondTupleData[0], int.Parse(secondTupleData[1]), isDrunk);
            Console.WriteLine(secondTuple.ToString());

            string[] thirdTupleData = Console.ReadLine().Split();
            MyTuple<string, double, string> thirdTuple = new MyTuple<string, double, string>(thirdTupleData[0], double.Parse(thirdTupleData[1]), thirdTupleData[2]);
            Console.WriteLine(thirdTuple.ToString());
        }
    }
}
