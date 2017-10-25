using System;
using System.Linq;

namespace _01._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputInCharsAndReverse = input.ToCharArray().Reverse().ToArray();
            Console.WriteLine(inputInCharsAndReverse);
        }
    }
}
