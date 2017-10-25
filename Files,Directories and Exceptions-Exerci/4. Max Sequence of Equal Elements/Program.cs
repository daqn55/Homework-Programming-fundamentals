using System;
using System.IO;
using System.Linq;

namespace _04._Max_Sequence_of_Equal_Elements
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

                int count = 0;
                int bestCount = 0;
                int start = 0;
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (data[i] == data[i + 1])
                    {
                        count++;
                        if (count > bestCount)
                        {
                            start = i - count;
                            bestCount = count;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
                for (int i = start + 1; i <= start + bestCount + 1; i++)
                {
                    File.AppendAllText("Output.txt", $"{data[i]} ");
                }
                File.AppendAllText("Output.txt", "\r\n");
            }
        }
    }
}
