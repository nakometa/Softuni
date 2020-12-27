using System;

namespace _06.VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            double num = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentSelection = text[i];
                switch (currentSelection)
                {
                    case 'a':
                        num += 1;
                        break;
                    case 'e':
                        num += 2;
                        break;
                    case 'i':
                        num += 3;
                        break;
                    case 'o':
                        num += 4;
                        break;
                    case 'u':
                        num += 5;
                        break;
                }
            }
            Console.WriteLine(num);
        }
    }
}
