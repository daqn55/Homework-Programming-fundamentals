using System;
using System.Numerics;

namespace _13._Factorial
{
    class Program
    {
        static int CountZerosFactorial(BigInteger num)
        {
            int count = 0;
            for (int i = 0; i <= num; i++)
            {
                if (num % 10 == 0)
                {
                    count++;
                    num /= 10;
                }
                else
                {
                    break;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine(CountZerosFactorial(result));
        }
    }
}