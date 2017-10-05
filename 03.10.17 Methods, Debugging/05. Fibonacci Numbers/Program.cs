using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static int fibonacci(int num)
        {
            long oldNum = 0;
            long newNum = 1;
            for (int i = 0; i < num; i++)
            {
                long temp = oldNum;
                oldNum = newNum;
                newNum = temp + newNum;
                
            }
            Console.WriteLine(newNum);
            return num;
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            fibonacci(num);
        }
    }
}
