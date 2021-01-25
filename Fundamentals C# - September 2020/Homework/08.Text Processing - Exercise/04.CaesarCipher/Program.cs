using System;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string encryptedOutput = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                int currentChar = input[i] + 3;
                encryptedOutput += (char)currentChar;
            }
            Console.WriteLine(encryptedOutput);
        }
    }
}
