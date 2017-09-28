using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool special = false;
            int num1 = 0;
            int num2 = 0;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                num1 = i % 10;
                num2 = i / 10;
                sum = num1 + num2;
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    special = true;
                }
                else
                {
                    special = false;
                }
                Console.WriteLine($"{i} -> {special}");
            }
        }
    }
}
