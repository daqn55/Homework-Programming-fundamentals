using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = Console.ReadLine().Split().Select(int.Parse).ToList();

            int count = 1;
            int bestCount = 1;
            int bestNumber = 0;

            for (int i = 0; i < data.Count - 1; i++)
            {
                if (data[i] == data[i + 1])
                {
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestNumber = data[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }
            if (bestNumber == 0)
            {
                Console.WriteLine(data[0]);
            }
            else
            {
                for (int i = 0; i < bestCount; i++)
                {
                    Console.Write($"{bestNumber} ");
                }
                Console.WriteLine();
            }
        }
    }
}
