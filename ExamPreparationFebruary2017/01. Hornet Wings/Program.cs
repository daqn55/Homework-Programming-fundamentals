using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            double distance = (n / 1000) * m;
            int flapsForSeconds = n / 100;
            double secondsToTravel = (n / p) * 5 + flapsForSeconds;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{secondsToTravel:f0} s.");
            
        }
    }
}
