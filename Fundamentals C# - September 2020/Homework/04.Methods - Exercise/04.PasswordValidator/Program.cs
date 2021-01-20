using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isLongEnough = PasswordLengthCheck(input);
            bool isAllowed = PasswordLettersCheck(input);
            bool hasTwoDigits = PasswordDigitsChecker(input);

            if (isLongEnough && isAllowed && hasTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!isLongEnough)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!isAllowed)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!hasTwoDigits)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        private static bool PasswordDigitsChecker(string password)
        {
            int counter = 0;
            foreach (char c in password)
            {
                bool isDigit = Char.IsDigit(c);
                if (isDigit)
                {
                    counter++;
                    if (counter == 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool PasswordLettersCheck(string password)
        {

            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool PasswordLengthCheck(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            return false;
        }
    }
}
