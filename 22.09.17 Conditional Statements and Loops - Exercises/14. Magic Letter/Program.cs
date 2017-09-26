using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char y = firstLetter; y <= secondLetter; y++)
                {
                    for (char z = firstLetter; z <= secondLetter; z++)
                    {
                        if (i == thirdLetter || y == thirdLetter || z == thirdLetter)
                        {

                        }
                        else
                        {
                            Console.Write($"{i}{y}{z} ");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
