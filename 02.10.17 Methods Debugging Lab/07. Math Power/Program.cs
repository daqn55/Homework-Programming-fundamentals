using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Math_Power
{
    class Program
    {
        static double RiseToPower(double number, int power)
        {
            double multiply = number;
            for (int i = 1; i < power; i++)
            {
                multiply = multiply * number;
            }
            return multiply;
        }

        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double numInPower = RiseToPower(num, (int)power);
            Console.WriteLine(numInPower);
        }
    }
}
