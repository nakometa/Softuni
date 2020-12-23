using System;

namespace _06.WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int firstSectorRows = int.Parse(Console.ReadLine());
            int oddSeats = int.Parse(Console.ReadLine());
            char a = 'a';
            int counter = 0;

            for (char i = 'A'; i <= lastSector; i++)
            {
                for (int k = 1; k <= firstSectorRows; k++)
                {
                    if (k % 2 == 0)
                    {
                        for (int j = 0; j < oddSeats + 2; j++)
                        {
                            Console.WriteLine($"{i}{k}{a}");
                            a++;
                            counter++;
                        }
                        a = 'a';
                    }
                    else
                    {
                        for (int j = 0; j < oddSeats; j++)
                        {
                            Console.WriteLine($"{i}{k}{a}");
                            a++;
                            counter++;
                        }
                        a = 'a';
                    }
                }
                firstSectorRows++;
            }
            Console.WriteLine(counter);
        }
    }
}
