using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int sum = 0;
            int num1 = 0;
            int num2 = 0;
            int count = 0;
            for (int i = m; i >= n; i--)
            {
                for (int u = m; u >= n; u--)
                {
                    sum = i + u;
                    num1 = i;
                    num2 = u;
                    count++;
                    if (sum == magicNum)
                    {
                        break;
                    }
                }
                if (sum == magicNum)
                {
                    break;
                }
            }
            if (sum == magicNum)
            {
                Console.WriteLine($"Number found! {num1} + {num2} = {sum}");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNum}");
            }
        }
    }
}
