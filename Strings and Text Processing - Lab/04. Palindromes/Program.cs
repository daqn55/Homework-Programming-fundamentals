using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', '?', '!', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            SortedDictionary<string, int> checkForMoreThanOnePalindromes = new SortedDictionary<string, int>();

            foreach (var word in input)
            {
                char[] reverseWord = word.ToCharArray().Reverse().ToArray();
                string newWord = new string(reverseWord);
                if (string.Compare(word, newWord) == 0)
                {
                    if (checkForMoreThanOnePalindromes.Keys.Contains(word))
                    {
                        checkForMoreThanOnePalindromes[word] += 1;
                    }
                    else
                    {
                        checkForMoreThanOnePalindromes.Add(word, 1);
                    }
                }
            }
            int count = 1;
            foreach (var item in checkForMoreThanOnePalindromes)
            {
                if (item.Value >= 1)
                {
                    if (count == checkForMoreThanOnePalindromes.Count)
                    {
                        Console.WriteLine(item.Key);
                    }
                    else
                    {
                        Console.Write($"{item.Key}, ");
                    }
                }
                count++;
            }
        }
    }
}
