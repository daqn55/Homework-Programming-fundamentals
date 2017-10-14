using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] comands = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (data.Contains(comands[0]))
            {
                int count = 0;
                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i] == comands[0])
                    {
                        break;
                    }
                    count++;
                }
                if (data.Count < count + comands[1] + 1)
                {
                    data.RemoveRange(count, 2);
                    data.RemoveRange(count - comands[1], comands[1]);
                }
                else if (count - comands[1] < 0)
                {
                    data.RemoveRange(count, comands[1] + 1);
                    data.RemoveRange(0, count);
                }
                else
                {
                    data.RemoveRange(count, comands[1] + 1);
                    data.RemoveRange(count - comands[1], comands[1]);
                }
            }

            int sumNumbers = 0;
            for (int i = 0; i < data.Count; i++)
            {
                sumNumbers += data[i];
            }
            Console.WriteLine(sumNumbers);
        }
    }
}
