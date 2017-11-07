using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _04.Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> storedData = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, Dictionary<string, long>> reserveStoredData = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "thetinggoesskrra")
                {
                    break;
                }
                string[] data = input.Split(new[] { " -> ", " | " }, StringSplitOptions.RemoveEmptyEntries);
                if (data.Length == 1)
                {
                    storedData.Add(data[0], new Dictionary<string, long>());
                    if (reserveStoredData.ContainsKey(data[0]))
                    {
                        foreach (var item in reserveStoredData[data[0]])
                        {
                            storedData[data[0]].Add(item.Key, item.Value);
                        }
                    }
                
                }
                else if(data.Length > 1)
                {
                    if (storedData.ContainsKey(data[2]))
                    {
                        storedData[data[2]].Add(data[0], long.Parse(data[1]));
                    }
                    else
                    {
                        if (reserveStoredData.ContainsKey(data[2]))
                        {
                            reserveStoredData[data[2]].Add(data[0], long.Parse(data[1]));
                        }
                        else
                        {
                            reserveStoredData.Add(data[2], new Dictionary<string, long>());
                            reserveStoredData[data[2]].Add(data[0], long.Parse(data[1]));
                        }
                    }
                }
            }
            BigInteger greaterSum = 0;
            string biggerSize = "";
            foreach (var item in storedData)
            {
                long tempSum = 0;
                foreach (var val in item.Value)
                {
                    tempSum += val.Value;
                    if (greaterSum < tempSum)
                    {
                        biggerSize = item.Key;
                        greaterSum = tempSum;
                    }
                }
            }
            if (biggerSize != "")
            {
                Console.WriteLine($"Data Set: {biggerSize}, Total Size: {greaterSum}");
                foreach (var item in storedData[biggerSize])
                {
                    Console.WriteLine($"$.{item.Key}");
                }
            }
            else
            {
                if (storedData.Count == 1)
                {
                    Console.WriteLine($"Data Set: {storedData.Keys.First()}, Total Size: {0}");
                }
            }
        }
    }
}
