using System;
using System.Linq;

namespace _06._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = 0;
            int bestCount = 0;
            int start = 0;
            for (int i = 0; i < data.Length - 1; i++)
            {
                if (data[i] < data[i + 1])
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
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();
        }
    }
}
