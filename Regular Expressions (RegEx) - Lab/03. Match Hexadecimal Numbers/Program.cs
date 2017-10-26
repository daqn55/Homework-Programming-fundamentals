using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            List<string> result = new List<string>();

            foreach (Match match in matches)
            {
                result.Add(match.Value);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
