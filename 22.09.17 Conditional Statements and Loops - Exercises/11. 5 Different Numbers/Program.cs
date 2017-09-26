using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            bool check = false;

            for (int i = a; i <= b; i++)
            {
                for (int n1 = a; n1 <= b; n1++)
                {
                    for (int n2 = a; n2 <= b; n2++)
                    {
                        for (int n3 = a; n3 <= b; n3++)
                        {
                            for (int n4 = a; n4 <= b; n4++)
                            {
                                if (a <= i && i < n1 && n1 < n2 && n2 < n3 && n3 < n4 && n4 <= b)
                                {
                                    Console.WriteLine($"{i} {n1} {n2} {n3} {n4}");
                                    check = true;
                                }
                                
                            }
                        }
                    }
                }
            }
            if (check == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
