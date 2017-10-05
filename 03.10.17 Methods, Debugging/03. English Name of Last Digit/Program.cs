using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_of_Last_Digit
{
    class Program
    {

        static void Main(string[] args)
        {   
            string[] digitName = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            long num = long.Parse(Console.ReadLine());
            num = Math.Abs(num) % 10;
            Console.WriteLine(digitName[num]);
        }
    }
}
