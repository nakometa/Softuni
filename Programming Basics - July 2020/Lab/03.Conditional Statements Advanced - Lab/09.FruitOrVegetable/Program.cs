using System;

namespace _09.FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();

            string type = "";

            switch (item)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    type = "fruit";
                    break;
                case "cucumber":
                case "pepper":
                case "carrot":
                case "tomato":
                    type = "vegetable";
                    break;
                default:
                    type = "unknown";
                    break;
            }
            Console.WriteLine(type);
        }
    }
}
