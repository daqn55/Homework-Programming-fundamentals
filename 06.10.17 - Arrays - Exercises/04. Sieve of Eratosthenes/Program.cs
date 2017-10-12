using System;

namespace _04._Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int count = 0;
                for (int y = 1; y < i; y++)
                {
                    if (i % y == 0)
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}
