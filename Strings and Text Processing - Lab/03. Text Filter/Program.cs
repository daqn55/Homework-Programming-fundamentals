using System;

namespace _03._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();


            foreach (var banWord in banWords)
            {
                input = input.Replace(banWord, new string('*', banWord.Length));
            }
            Console.WriteLine(input);
        }
    }
}
