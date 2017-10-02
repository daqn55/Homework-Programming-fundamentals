using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string toHex = num.ToString("X");
            Console.WriteLine(toHex);
            string toBinary = Convert.ToString(num, 2);
            Console.WriteLine(toBinary);
        }
    }
}
