using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().ToCharArray().Select(x => x.ToString()).Select(int.Parse).ToArray();
            int numToMultiply = int.Parse(Console.ReadLine());

            List<int> result = new List<int>();
            if (numToMultiply == 0)
            {
                Console.WriteLine(0);
            }
            else if (numToMultiply > 0 && numToMultiply < 10)
            {
                int memoryNum = 0;
                for (int i = input.Length-1; i >= 0; i--)
                {
                    int sum = 0;
                    sum = ((input[i] * numToMultiply) + memoryNum) % 10;
                    memoryNum = (input[i] * numToMultiply + memoryNum) / 10;
                    result.Add(sum);
                }
                if (memoryNum > 0 && memoryNum < 10)
                {
                    result.Add(memoryNum);
                }
                result.Reverse();
                Console.WriteLine(string.Join("", result).TrimStart('0'));
            }
        }
    }
}
