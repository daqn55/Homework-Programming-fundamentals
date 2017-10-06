using System;

namespace _06._Prime_Checker
{
    class Program
    {
        static bool IsPrime(long num)
        {
            int count = 0;
            for (long i = 1; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
                if (count > 2)
                {
                    break;
                }
            }
            if (num == 0 || num == 1)
            {
                return false;
            }
            else if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(num));
        }
    }
}
