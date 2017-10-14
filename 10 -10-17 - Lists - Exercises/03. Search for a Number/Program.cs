using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] comands = Console.ReadLine().Split().Select(int.Parse).ToArray();

            data.RemoveRange(comands[0], data.Count - comands[0]);
            data.RemoveRange(0, comands[1]);
            if (data.Contains(comands[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
