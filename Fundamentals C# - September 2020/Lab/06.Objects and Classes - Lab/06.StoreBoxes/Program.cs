using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<Box> boxes = new List<Box>();

            while (input[0] != "end")
            {
                Item currentItem = new Item();
                Box currentBox = new Box();
                currentItem.Name = input[1];
                currentItem.Price = double.Parse(input[3]);
                currentBox.Item = currentItem;
                currentBox.SerialNumber = input[0];
                currentBox.ItemQuantity = int.Parse(input[2]);
                currentBox.BoxPrice = currentBox.Item.Price * currentBox.ItemQuantity;
                boxes.Add(currentBox);

                input = Console.ReadLine().Split();
            }

            foreach (Box box in boxes.OrderByDescending(x => x.BoxPrice))
            {
                Console.WriteLine($"{box.SerialNumber}\n-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}\n-- ${box.BoxPrice:F2}");
            }
        }

        class Item
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }

        class Box
        {
            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemQuantity { get; set; }
            public double BoxPrice { get; set; }
        }
    }
}
