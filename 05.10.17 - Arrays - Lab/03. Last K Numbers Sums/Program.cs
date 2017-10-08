using System;

namespace _03._Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] seq = new long[n];

            seq[0] = 1;
            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                if (i < k)
                {
                    for (int y = k - 1; y >= 0; y--)
                    {
                        sum = sum + seq[y];
                        seq[i] = sum;
                    }
                }
                else
                {
                    for (int y = i; y >= i - k; y--)
                    {
                        sum = sum + seq[y];
                        seq[i] = sum;
                    }
                }

            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{seq[i]} ");
            }
            Console.WriteLine();
        }
    }
}
