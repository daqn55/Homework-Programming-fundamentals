using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int metres = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float metersPerSeconds = metres / ((hours * 60f + minutes) * 60f + seconds);
            Console.WriteLine(metersPerSeconds);
            float kilometersPerHours = (metres / 1000f) / (((seconds / 60f + minutes) / 60f) + hours);
            Console.WriteLine(kilometersPerHours);
            float milesPerHours = (metres / 1609f) / (((seconds / 60f + minutes) / 60f) + hours);
            Console.WriteLine(milesPerHours);
        }
    }
}
