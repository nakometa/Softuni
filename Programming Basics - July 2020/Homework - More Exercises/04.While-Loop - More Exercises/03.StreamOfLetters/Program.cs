using System;

namespace _03.StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string secretWord = "";
            string currentWord = "";
            int counterC = 0;
            int counterO = 0;
            int counterN = 0;

            while (input != "End")
            {
                char currentLetter = char.Parse(input);
                if (((int)currentLetter >= 97 && (int)currentLetter <= 122) || ((int)currentLetter >= 65 && (int)currentLetter <= 90))
                {
                    if (currentLetter == 'c')
                    {
                        counterC++;
                        if (counterC > 1)
                        {
                            secretWord += 'c';
                        }
                    }
                    else if (currentLetter == 'o')
                    {
                        counterO++;
                        if (counterO > 1)
                        {
                            secretWord += 'o';
                        }
                    }
                    else if (currentLetter == 'n')
                    {
                        counterN++;
                        if (counterN > 1)
                        {
                            secretWord += 'n';
                        }
                    }
                    if (currentLetter != 'o' && currentLetter != 'c' && currentLetter != 'n')
                    {
                        secretWord += currentLetter;
                    }
                    if (counterC >= 1 && counterO >= 1 && counterN >= 1)
                    {
                        counterC = 0;
                        counterO = 0;
                        counterN = 0;
                        currentWord += secretWord + " ";
                        secretWord = "";
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(currentWord);
        }
    }
}
