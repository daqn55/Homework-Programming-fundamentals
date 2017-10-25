using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstNumber = Console.ReadLine().ToCharArray().Select(x => x.ToString()).Select(int.Parse).ToArray();
            int[] secondNumber = Console.ReadLine().ToCharArray().Select(x => x.ToString()).Select(int.Parse).ToArray();

            List<int> firstNumberInInt = new List<int>();
            List<int> secondNumberInInt = new List<int>();
            int zerosToAdd = 0;
            if (firstNumber.Length >= secondNumber.Length)
            {
                firstNumberInInt.AddRange(firstNumber);
                zerosToAdd = firstNumber.Length - secondNumber.Length;
                secondNumberInInt.AddRange(secondNumber);
                secondNumberInInt.InsertRange(0, new int[zerosToAdd]);
            }
            else
            {
                firstNumberInInt.AddRange(secondNumber);
                zerosToAdd = secondNumber.Length - firstNumber.Length;
                secondNumberInInt.AddRange(firstNumber);
                secondNumberInInt.InsertRange(0, new int[zerosToAdd]);

            }
            List<int> result = new List<int>();
            int numInRemaind = 0;
            for (int i = firstNumberInInt.Count - 1; i >= 0; i--)
            {
                int sum = 0;
                if (firstNumberInInt[i] + secondNumberInInt[i] + numInRemaind < 10)
                {
                    if (numInRemaind == 1)
                    {
                        sum = firstNumberInInt[i] + secondNumberInInt[i] + numInRemaind;
                        numInRemaind = 0;
                        result.Add(sum);
                    }
                    else
                    {
                        sum = firstNumberInInt[i] + secondNumberInInt[i];
                        numInRemaind = 0;
                        result.Add(sum);
                    }

                }
                else
                {
                    if (numInRemaind == 1)
                    {
                        sum = (firstNumberInInt[i] + secondNumberInInt[i] + numInRemaind) % 10;
                        numInRemaind = 1;
                        result.Add(sum);
                    }
                    else
                    {
                        sum = (firstNumberInInt[i] + secondNumberInInt[i]) % 10;
                        numInRemaind = 1;
                        result.Add(sum);
                    }

                }
            }
            if (numInRemaind == 1)
            {
                result.Add(numInRemaind);
            }
            result.Reverse();
            string finalResult = string.Join("", result).TrimStart('0');
            Console.WriteLine(finalResult);
        }
    }
}
