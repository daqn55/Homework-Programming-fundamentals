using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());

            string reverseNumberInString = new string(number.ToString().Reverse().ToArray());
            decimal reverseNum = decimal.Parse(reverseNumberInString);

            Console.WriteLine(reverseNum);

        }
    }
}
