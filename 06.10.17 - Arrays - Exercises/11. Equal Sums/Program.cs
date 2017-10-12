using System;
using System.Linq;

namespace _11._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

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
                    Console.WriteLine(i);
                    break;
                }
            }
            if (isIndexExists == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
