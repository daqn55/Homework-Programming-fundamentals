using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] data = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var dictData = new SortedDictionary<double, int>();

            foreach (var item in data)
            {
                if (dictData.ContainsKey(item))
                {
                    dictData[item]++;
                }
                else
                {
                    dictData[item] = 1;
                }
            }
            foreach (var item in dictData)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
