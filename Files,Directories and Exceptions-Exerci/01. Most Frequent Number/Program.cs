using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = File.ReadAllLines("Input.txt");
            List<string> savedNumbers = new List<string>();
            File.WriteAllText("Output.txt", "");
            foreach (var input in inputs)
            {
                int[] checkNumber = input.Split(' ').Select(int.Parse).ToArray();
                int bestCount = 0;
                int savedNum = 0;
                for (int i = 0; i < checkNumber.Length; i++)
                {
                    int count = 0;
                    for (int y = 0; y < checkNumber.Length; y++)
                    {
                        if (checkNumber[i] == checkNumber[y])
                        {
                            count++;
                        }
                        if (bestCount < count)
                        {
                            savedNum = checkNumber[y];
                            bestCount = count;
                        }
                    }
                }
                savedNumbers.Add(savedNum.ToString());
            }
            File.AppendAllLines("Output.txt", savedNumbers);
        }
    }
}
