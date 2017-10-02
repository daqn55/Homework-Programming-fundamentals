using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double numA = double.Parse(Console.ReadLine());
            double numB = double.Parse(Console.ReadLine());

            bool comp = Math.Abs(numA - numB) < 0.000001;
            Console.WriteLine(comp);
        }
    }
}
