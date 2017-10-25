using System;
using System.IO;
using System.Linq;

namespace _11._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = File.ReadAllLines("Input.txt");
            File.WriteAllText("Output.txt", "");

            foreach (var item in inputs)
            {
                int[] data = item.Split().Select(int.Parse).ToArray();

                bool isIndexExists = false;
                for (int i = 0; i < data.Length; i++)
                {
                    int reverseSum = 0;
                    int sum = 0;
                    for (int y = i; y < data.Length; y++)
                    {
                        sum += data[y];
                    }
                    for (int z = i; z >= 0; z--)
                    {
                        reverseSum += data[z];
                    }
                    if (sum == reverseSum)
                    {
                        isIndexExists = true;
                        File.AppendAllText("Output.txt", $"{i.ToString()}\r\n");
                        break;
                    }
                }
                if (isIndexExists == false)
                {
                    File.AppendAllText("Output.txt", "no\r\n");
                }
            }
            
        }
    }
}