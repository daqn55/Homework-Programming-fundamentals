using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Greater_of_Two_Values
{
    class Program
    {
        static int GetMax(int num1, int num2)
        {
            if (num1 >= num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        static char GetMax(char letter1, char letter2)
        {
            if (letter1 >= letter2)
            {
                return letter1;
            }
            else
            {
                return letter2;
            }
        }

        static string GetMax(string word1, string word2)
        {
            if (word1.CompareTo(word2) > 0)
            {
                return word1;
            }
            else
            {
                return word2;
            }
        }

        static void Main(string[] args)
        {
            var type = Console.ReadLine();

            if (type == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                int greaterNum = GetMax(num1, num2);
                Console.WriteLine(greaterNum);
            }
            else if (type == "char")
            {
                char firstLetter = char.Parse(Console.ReadLine());
                char secondLetter = char.Parse(Console.ReadLine());

                char greaterChar = GetMax(firstLetter, secondLetter);
                Console.WriteLine(greaterChar);
            }
            else if (type == "string")
            {
                string firstWord = Console.ReadLine();
                string secondWord = Console.ReadLine();

                string greaterString = GetMax(firstWord, secondWord);
                Console.WriteLine(greaterString);
            }
        }
    }
}
