using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Z][A-Z])([0-9]+.[0-9]+)([A-Za-z]+)(?=\|)";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<double, string>> citiesWeather = new Dictionary<string, Dictionary<double, string>>();

            while (input != "end")
            {
                MatchCollection match = regex.Matches(input);
                foreach (Match item in match)
                {
                    if (citiesWeather.ContainsKey(item.Groups[1].Value))
                    {
                        citiesWeather[item.Groups[1].Value].Clear();
                        citiesWeather[item.Groups[1].Value].Add(double.Parse(item.Groups[2].Value), item.Groups[3].Value);
                    }
                    else
                    {
                        Dictionary<double, string> nestetDict = new Dictionary<double, string>();
                        nestetDict.Add(double.Parse(item.Groups[2].Value), item.Groups[3].Value);
                        citiesWeather.Add(item.Groups[1].Value, nestetDict);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in citiesWeather.OrderBy(x => x.Value.Keys.First()))
            {
                Console.Write(item.Key + " => ");
                Console.WriteLine($"{item.Value.Keys.First():f2}" + " => " + item.Value.Values.First());
            }
        }
    }
}
