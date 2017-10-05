using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void PrintHeader(int num)
        {
            Console.WriteLine(new string('-', num * 2));
        }
        static void PrintBody(int num)
        {
            for (int j = 0; j < num - 2; j++)
            {
                Console.Write("-");
                for (int i = 0; i < num - 1; i++)
                {
                    Console.Write("\\");
                    Console.Write("/");
                }
                Console.Write("-");
                Console.WriteLine();
            }  
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeader(n);
            PrintBody(n);
            PrintHeader(n);
        }
    }
}
