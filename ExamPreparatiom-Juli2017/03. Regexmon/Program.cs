using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string didiAndBojo = @"([^-a-zA-Z]+)|([a-zA-Z]+-[a-zA-z]+)\b";

            List<KeyValuePair<string, string>> matches = new List<KeyValuePair<string, string>>();
            foreach (Match didi in Regex.Matches(input, didiAndBojo))
            {
                matches.Add(new KeyValuePair<string, string>("didi", didi.Groups[1].Value));
                matches.Add(new KeyValuePair<string, string>("bojo" ,didi.Groups[2].Value));
            }
            int count = 1;
            foreach (var item in matches.Where(x => x.Value.Length > 0))
            {
                if (item.Key == "didi" && count % 2 == 1)
                {
                    Console.WriteLine(item.Value.Trim());
                    count++;
                }
                if (item.Key == "bojo" && count % 2 == 0)
                {
                    Console.WriteLine(item.Value.Trim());
                    count++;
                }
            }
        }
    }
}
