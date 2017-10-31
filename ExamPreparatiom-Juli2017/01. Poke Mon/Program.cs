using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int countOfTargets = 0;
            int originN = n;

            while (n >= m)
            {
                if (originN / 2 == n)
                {
                    if (y > 1)
                    {
                        n /= y;
                    }
                    else
                    {
                        n -= m;
                        countOfTargets++;
                    }
                }
                else
                {
                    n -= m;
                    countOfTargets++;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(countOfTargets);
        }
    }
}
