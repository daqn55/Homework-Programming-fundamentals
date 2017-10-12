using System;
using System.Linq;

namespace _10._Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int diffrence = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int y = 0; y < data.Length; y++)
                {
                    if (data[i] + diffrence == data[y])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
