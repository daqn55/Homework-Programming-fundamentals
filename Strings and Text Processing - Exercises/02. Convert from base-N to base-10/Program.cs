using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01._Convert_from_base_10_to_base_N
{
    class Program
    {
        static BigInteger NumberInPower(BigInteger power, BigInteger baseNum)
        {
            BigInteger saveBseNum = baseNum;
            for (int i = 0; i <= power; i++)
            {
                if (i == 0)
                {
                    baseNum = 1;
                }
                else if (i == 1)
                {
                    baseNum = saveBseNum;
                }
                else
                {
                    baseNum *= saveBseNum;
                }
            }
            return baseNum;
        }

        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            BigInteger baseTenNum = input[1];
            BigInteger baseNumberToConvert = 10;
            List<BigInteger> result = new List<BigInteger>();
            while (baseTenNum >= 1)
            {
                result.Add(baseTenNum % baseNumberToConvert);
                baseTenNum /= baseNumberToConvert;
            }
            for (int i = 0; i < result.Count; i++)
            {
                result[i] *= NumberInPower(i, input[0]);
            }
            BigInteger finalResult = 0;
            foreach (var item in result)
            {
                finalResult += item;
            }
            Console.WriteLine(finalResult);
        }
    }
}
