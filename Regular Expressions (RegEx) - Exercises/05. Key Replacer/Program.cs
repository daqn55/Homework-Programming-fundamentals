using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] startKeyEndKey = Console.ReadLine().Split(new char[] { '|', '<', '\\' }, StringSplitOptions.RemoveEmptyEntries);
            string inputText = Console.ReadLine();

            string pattern = $@"(?<={startKeyEndKey.First()})[^{startKeyEndKey.Last()}](\w+?)(?={startKeyEndKey.Last()})";
            Regex regex = new Regex(pattern);
            MatchCollection match = regex.Matches(inputText);

            bool matched = false;
            foreach (Match item in match)
            {
                Console.Write(item);
                matched = true;
            }
            if (!matched)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
