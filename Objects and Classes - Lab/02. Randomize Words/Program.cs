using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();

            List<string> arrayOfWords = words.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Random rnd = new Random();
            
            for (int i = 0; i < arrayOfWords.Count; i++)
            {
                int randomNum = rnd.Next(arrayOfWords.Count);
                string temp = "";

                temp = arrayOfWords[i];
                arrayOfWords[i] = arrayOfWords[randomNum];
                arrayOfWords[randomNum] = temp;
            }

            foreach (var item in arrayOfWords)
            {
                Console.WriteLine(item);
            }
        }
    }
}
