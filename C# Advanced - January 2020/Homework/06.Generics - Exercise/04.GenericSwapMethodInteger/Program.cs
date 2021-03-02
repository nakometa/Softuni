using System;
using System.Collections.Generic;

namespace _04.GenericSwapMethodInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<int>> boxes = new List<Box<int>>();

            for (int i = 0; i < n; i++)
            {
                Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
                boxes.Add(box);
            }
            string[] indexes = Console.ReadLine().Split();
            int firstIndex = int.Parse(indexes[0]);
            int secondIndex = int.Parse(indexes[1]);
            Box<int>.SwapIndexes(boxes, firstIndex, secondIndex);

            foreach (var item in boxes)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
