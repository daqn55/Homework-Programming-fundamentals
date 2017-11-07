using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] secondInput = Console.ReadLine().Split(new[] { "{", "}" }, StringSplitOptions.RemoveEmptyEntries);
            
            string pattern = @"([a-zA-Z]+)(.+)(\1)";
            Regex regex = new Regex(pattern);
            MatchCollection match = regex.Matches(input);

            string result = "";
            foreach (var item in secondInput)
            {
                item.Trim();
            }
            int i = 0;
            foreach (Match item in Regex.Matches(input, pattern))
            {
                result = item.Value.Replace(item.Groups[2].Value, secondInput[i]);
                input = input.Replace(item.Groups[1].Value + item.Groups[2].Value + item.Groups[3].Value, result);
                i++;
            }
            Console.WriteLine(input);
        }
    }
}
