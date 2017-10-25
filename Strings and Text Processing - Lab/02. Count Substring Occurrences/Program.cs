using System;

namespace _02._Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string wordToCount = Console.ReadLine().ToLower();

            int count = 0;
            int index = input.IndexOf(wordToCount);
            while (index != -1)
            {
                count++;
                index = input.IndexOf(wordToCount, index + 1);
            }
            Console.WriteLine(count);
        }
    }
}
