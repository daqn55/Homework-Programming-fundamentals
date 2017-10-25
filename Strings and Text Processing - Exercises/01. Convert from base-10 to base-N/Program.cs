using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01._Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            BigInteger baseTenNum = input[1];
            BigInteger baseNumberToConvert = input[0];
            List<BigInteger> result = new List<BigInteger>();
            while (baseTenNum >= 1)
            {
                result.Add(baseTenNum % baseNumberToConvert);
                baseTenNum /= baseNumberToConvert;
            }
            result.Reverse();
            foreach (var item in result)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
