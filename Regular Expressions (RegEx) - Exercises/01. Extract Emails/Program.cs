using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<![\-_.a-z0-9])[a-zA-Z0-9]+[\.|\-|_|a-z][a-z]+@[a-z]+[\-|a-z]+\.[a-z.]+\b";
            Regex regex = new Regex(pattern);

            MatchCollection match = regex.Matches(input);
            
            foreach (Match item in match)
            {
                Console.WriteLine(item);
            }
        }
    }
}
