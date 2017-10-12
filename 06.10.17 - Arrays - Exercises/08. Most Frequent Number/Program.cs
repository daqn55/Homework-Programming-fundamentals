using System;
using System.Linq;

namespace _08._Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxCount = 0;
            int bestMemNum = 0;
            int[] memData = new int[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                int count = 1;
                for (int y = i; y < data.Length; y++)
                {
                    if (data[i] == data[y])
                    {
                        count++;
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                        bestMemNum = data[i];
                    }
                }
            }
            Console.WriteLine(bestMemNum);
        }
    }
}
