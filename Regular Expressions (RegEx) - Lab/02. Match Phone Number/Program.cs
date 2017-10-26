using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\+359([ -])2\1[\d]{3}\1[\d]{4}\b";

            Regex regex = new Regex(pattern);
            MatchCollection result = regex.Matches(input);
            List<string> phones = new List<string>();
            foreach (Match m in result)
            {
                phones.Add(m.Value);
            }

            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
