using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int smallerNum = 0;
            int biggerNum = 0;

            if (num1 > num2)
            {
                smallerNum = num2;
                biggerNum = num1;
            }
            else
            {
                smallerNum = num1;
                biggerNum = num2;
            }
            for (int i = smallerNum; i <= biggerNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
