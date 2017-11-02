using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string patternForLetters = @"[^\/\*\d\.+-]";
            string patternForDigits = @"[-|+]|\d+\.?\d*";
            string PatternForSpecialChars = @"[*|/]";
            Dictionary<string, Dictionary<long, decimal>> demons = new Dictionary<string, Dictionary<long, decimal>>();
            foreach (var item in input)
            {
                long health = 0;
                decimal damage = 0;
                foreach (Match mchLeters in Regex.Matches(item.Trim(), patternForLetters))
                {
                    health += (int)Convert.ToChar(mchLeters.Value);
                }
                bool isMinus = false;
                foreach (Match mchDigits in Regex.Matches(item.Trim(), patternForDigits))
                {
                    string digit = "";
                    decimal number = 0;
                    if (mchDigits.Value == "-")
                    {
                        isMinus = true;
                        continue;
                    }
                    else if (mchDigits.Value == "+")
                    {
                        isMinus = false;
                        continue;
                    }
                    if (isMinus)
                    {
                        for (int i = 0; i < mchDigits.Value.Length; i++)
                        {
                            digit += mchDigits.Value[i];
                        }
                        number = decimal.Parse(digit);
                        damage -= number;
                    }
                    else
                    {
                        for (int i = 0; i < mchDigits.Value.Length; i++)
                        {    
                                digit += mchDigits.Value[i];
                        }
                        decimal.TryParse(digit, out decimal s);
                        damage += s;
                    }
                    isMinus = false;
                }
                foreach (Match mchSpecial in Regex.Matches(item.Trim(), PatternForSpecialChars))
                {
                    if (mchSpecial.Value == "*")
                    {
                        damage *= 2;
                    }
                    else if(mchSpecial.Value == "/")
                    {
                        damage /= 2;
                    }
                }

                demons.Add(item, new Dictionary<long, decimal>());
                demons[item].Add(health, damage);
            }

            foreach (var item in demons.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value.Keys.First()} health, {item.Value.Values.First():f2} damage");
            }
        }
    }
}
