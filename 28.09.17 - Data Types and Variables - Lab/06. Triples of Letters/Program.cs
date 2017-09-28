using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 'a'; i < 'a' + n; i++)
            {
                for (int y = 'a'; y < 'a' + n; y++)
                {
                    for (int z = 'a'; z < 'a' + n; z++)
                    {
                        Console.WriteLine($"{(char)i}{(char)y}{(char)z}");
                    }
                }
            }
        }
    }
}
