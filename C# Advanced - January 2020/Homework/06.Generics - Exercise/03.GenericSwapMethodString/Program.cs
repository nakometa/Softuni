using System;
using System.Collections.Generic;

namespace _03.GenericSwapMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<string>> boxes = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                Box<string> box = new Box<string>(Console.ReadLine());
                boxes.Add(box);
            }
            string[] indexes = Console.ReadLine().Split();
            int firstIndex = int.Parse(indexes[0]);
            int secondIndex = int.Parse(indexes[1]);
            Box<string>.SwapIndexes(boxes, firstIndex, secondIndex);

            foreach (var item in boxes)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
