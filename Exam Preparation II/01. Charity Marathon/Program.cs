using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int marathonDays = int.Parse(Console.ReadLine());
            long runnersCount = long.Parse(Console.ReadLine());
            int numOfLaps = int.Parse(Console.ReadLine());
            long lapLennght = long.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            decimal moneyPerKilo = decimal.Parse(Console.ReadLine());

            long runnersWillRun;
            if (trackCapacity * marathonDays >= runnersCount)
            {
                runnersWillRun = runnersCount;
            }
            else
            {
                runnersWillRun = trackCapacity * marathonDays;
            }
            long kilometersTotal = (runnersWillRun * numOfLaps * lapLennght) / 1000;
            decimal moneyRaised = kilometersTotal * moneyPerKilo;
            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}
