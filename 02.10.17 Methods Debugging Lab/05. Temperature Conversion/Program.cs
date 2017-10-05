using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Temperature_Conversion
{
    class Program
    {
        static void TempFahrenheidToCelsium(double fahrenheid)
        {
            double toCelsium = (fahrenheid - 32) * 5 / 9;
            Console.WriteLine($"{toCelsium:f2}");
        }
        static void Main(string[] args)
        {
            double fahrenheid = double.Parse(Console.ReadLine());
            TempFahrenheidToCelsium(fahrenheid);
        }
    }
}
