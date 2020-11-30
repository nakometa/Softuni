using System;

namespace _08.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int neighborAnimals = int.Parse(Console.ReadLine());
            double dogsFoodPrice = dogs * 2.5;
            double neighborAnimalsPrice = neighborAnimals * 4;

            double finalPrice = dogsFoodPrice + neighborAnimalsPrice;
            Console.WriteLine($"{finalPrice} lv.");
        }
    }
}
