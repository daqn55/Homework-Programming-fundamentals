using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Min__Max__Sum__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> data = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                data.Add(number);
            }
            Console.WriteLine($"Sum = {data.Sum()}");
            Console.WriteLine($"Min = {data.Min()}");
            Console.WriteLine($"Max = {data.Max()}");
            Console.WriteLine($"Average = {data.Average()}");
        }
    }
}
