using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().ToLower().Split().ToArray();

            var dictData = new Dictionary<string, int>();
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

            var result = new List<string>();
            foreach (var item in dictData)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
