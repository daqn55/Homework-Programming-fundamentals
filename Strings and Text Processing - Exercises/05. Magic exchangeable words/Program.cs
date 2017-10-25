using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            List<char> firsList = new List<char>();
            firsList.AddRange(input[0]);
            List<char> secondList = new List<char>();
            secondList.AddRange(input[1]);

            int firstCountWord = 0;
            int secondCountWord = 0;
            foreach (var item in firsList.Where(x => x != ' ').Distinct())
            {
                firstCountWord++;
            }
            foreach (var item in secondList.Where(x => x != ' ').Distinct())
            {
                secondCountWord++;
            }

            if (firstCountWord > secondCountWord || secondCountWord > firstCountWord)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
