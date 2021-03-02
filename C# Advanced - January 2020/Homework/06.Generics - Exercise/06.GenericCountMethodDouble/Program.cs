using System;
using System.Collections.Generic;

namespace _06.GenericCountMethodDouble
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<double>> boxes = new List<Box<double>>();

            for (int i = 0; i < n; i++)
            {
                Box<double> box = new Box<double>(double.Parse(Console.ReadLine()));
                boxes.Add(box);
            }
            Box<double> compareBox = new Box<double>(double.Parse(Console.ReadLine()));
            int count = CompareBox(boxes, compareBox);
            Console.WriteLine(count);
        }

        public static int CompareBox(List<Box<double>> boxes, Box<double> compareBox)
        {
            int count = 0;
            foreach (Box<double> box in boxes)
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
