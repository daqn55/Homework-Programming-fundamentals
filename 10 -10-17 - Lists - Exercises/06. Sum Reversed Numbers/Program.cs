using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sumNumbers = 0;
            for (int i = 0; i < data.Count; i++)
            {
                int result = 0;
                while (data[i] > 0)
                {
                    result = result * 10 + data[i] % 10;
                    data[i] /= 10;
                }
                sumNumbers += result;
            }
            Console.WriteLine(sumNumbers);
        }
    }
}
