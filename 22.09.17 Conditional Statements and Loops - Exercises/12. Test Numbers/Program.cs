using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNum = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 0;
            for (int i = n; i >= 1; i--)
            {
                for (int y = 1; y <= m; y++)
                {
                    if (sum >= controlNum)
                    {
                        break;
                    }
                    sum = sum + (3 * (i * y));
                    count++;
                }
            }
            Console.WriteLine($"{count} combinations");
            if (sum >= controlNum)
            {
                Console.WriteLine($"Sum: {sum} >= {controlNum}");
            }
            else
            {
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
