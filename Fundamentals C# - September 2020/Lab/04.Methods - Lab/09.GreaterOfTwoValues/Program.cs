using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string variableType = Console.ReadLine();
            string firstVar = Console.ReadLine();
            string secondVar = Console.ReadLine();

            switch (variableType)
            {
                case "int":
                    int firstNum = int.Parse(firstVar);
                    int secondNum = int.Parse(secondVar);
                    int maxNumber = GetMaxInt(firstNum, secondNum);
                    Console.WriteLine(maxNumber);
                    break;
                case "char":
                    char firstChar = char.Parse(firstVar);
                    char secondChar = char.Parse(secondVar);
                    char biggerChar = GetMaxChar(firstChar, secondChar);
                    Console.WriteLine(biggerChar);
                    break;
                case "string":
                    string biggestString = GetMaxString(firstVar, secondVar);
                    Console.WriteLine(biggestString);
                    break;
            }
        }

        static int GetMaxInt(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
            {
                return firstNum;
            }
            return secondNum;
        }

        static char GetMaxChar(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                return firstChar;
            }
            return secondChar;
        }

        static string GetMaxString(string firstString, string SecondString)
        {
            int comparison = firstString.CompareTo(SecondString);
            if (comparison > 0)
            {
                return firstString;
            }
            return SecondString;
        }
    }
}
