using System;
using System.Linq;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            string longNumber = Console.ReadLine().TrimStart('0');
            int multiplyNumber = int.Parse(Console.ReadLine());
            int temp = 0;

            if (longNumber == "" || multiplyNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }

            foreach (var character in longNumber.Reverse())
            {
                int digit = int.Parse(character.ToString());
                int result = digit * multiplyNumber + temp;
                int restDigit = result % 10;
                temp = result / 10;
                sb.Insert(0, restDigit);
            }

            if (temp > 0)
            {
                sb.Insert(0, temp);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}