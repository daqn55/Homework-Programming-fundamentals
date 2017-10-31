using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mAndN = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int m = mAndN[0];
            int n = mAndN[1];

            string input = Console.ReadLine();
            string pattern = "\\|<(\\w{" + m + "})(\\w{" + 0 +"," + n +"})";
            Regex regex = new Regex(pattern);
            MatchCollection match = regex.Matches(input);
            int count = 0;
            foreach (Match item in match)
            {
                count++;
                if (count == match.Count)
                {
                    Console.Write(item.Groups[2]);
                }
                else
                {
                    Console.Write(item.Groups[2] + ", ");
                }
            }
            Console.WriteLine();
        }
    }
}
