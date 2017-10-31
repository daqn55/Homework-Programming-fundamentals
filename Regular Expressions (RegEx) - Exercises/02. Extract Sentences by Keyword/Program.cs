using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string particularWord = Console.ReadLine();
            string pattern = $@"\b{particularWord}\b";
            string[] inputText = Console.ReadLine().Split(new char[] {'!', '?','.'});

            Regex regex = new Regex(pattern);
            

            foreach (var item in inputText)
            {
                if (regex.IsMatch(item))
                {
                    Console.WriteLine(item.Trim());
                }
            }
        }
    }
}
