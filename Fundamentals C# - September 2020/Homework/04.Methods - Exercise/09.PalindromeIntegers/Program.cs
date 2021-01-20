using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            while ((input = Console.ReadLine()) != "END")
            {
                int number = int.Parse(input);
                bool isPalindrome = CheckIfNumberIsPalindrome(number);
                if (isPalindrome)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }

        public static bool CheckIfNumberIsPalindrome(int number)
        {

            int tNumber = 0;
            int rem = 0;
            int rev = 0;

            tNumber = number;
            while (number > 0)
            {
                rem = number % 10;
                rev = rev * 10 + rem;
                number = number / 10;
            }
            if (rev == tNumber)
            {
                return true;
            }
            return false;
        }
    }
}
