using System;
using System.Linq;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(" ").ToArray();
            string[] secondArr = Console.ReadLine().Split(" ").ToArray();
            //
            foreach (string item in secondArr)
            {
                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (item == firstArr[i])
                    {
                        Console.Write(item + " ");
                        break;
                    }
                }
            }
        }
    }
}
