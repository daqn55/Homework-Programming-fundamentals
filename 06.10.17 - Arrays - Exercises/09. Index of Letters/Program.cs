using System;
using System.Linq;

namespace _09._Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] data = Console.ReadLine().ToCharArray();

            foreach (var item in data)
            {
                Console.Write($"{item} -> ");
                Console.WriteLine((int)item - 97);
            }
        }
    }
}
