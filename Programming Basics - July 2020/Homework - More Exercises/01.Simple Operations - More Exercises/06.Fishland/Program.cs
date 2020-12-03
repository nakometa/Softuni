using System;

namespace _06.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelPrice = double.Parse(Console.ReadLine());
            double spratPrice = double.Parse(Console.ReadLine());
            double bonito = double.Parse(Console.ReadLine());
            double horseMackarel = double.Parse(Console.ReadLine());
            double seaShells = double.Parse(Console.ReadLine());



            double bonitoPrice = mackerelPrice + mackerelPrice * 0.6;
            double bonitoSum = bonitoPrice * bonito;
            double horseMackarelPrice = spratPrice + spratPrice * 0.8;
            double horseMackarelSum = horseMackarel * horseMackarelPrice;
            double seaShellsPrice = seaShells * 7.5;

            double totalPrice = bonitoSum + horseMackarelSum + seaShellsPrice;

            Console.WriteLine("{0:0.00}", totalPrice);
        }
    }
}
