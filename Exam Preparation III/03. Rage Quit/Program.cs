using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\D+)(\d+)";
            Regex regex = new Regex(pattern);
            MatchCollection match = regex.Matches(input);

            StringBuilder result = new StringBuilder();
            foreach (Match m in match)
            {
                for (int i = 0; i < int.Parse(m.Groups[2].Value); i++)
                {
                    result.Append(m.Groups[1].Value.ToUpper());
                }
            }
            int count = result.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(result);
        }
    }
}
