using System;
using System.Collections.Generic;

namespace _05.GenericCountMethodString
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
            Box<string> compareBox = new Box<string>(Console.ReadLine());
            int count = CompareBox(boxes, compareBox);
            Console.WriteLine(count);
        }

        public static int CompareBox(List<Box<string>> boxes, Box<string> compareBox)
        {
            int count = 0;
            foreach (Box<string> box in boxes)
            {
                if (box.value.CompareTo(compareBox.value) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
