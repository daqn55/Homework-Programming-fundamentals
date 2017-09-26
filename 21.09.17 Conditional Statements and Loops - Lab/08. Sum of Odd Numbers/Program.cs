using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int n = 1;
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(n);
                sum += n;
                n += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
