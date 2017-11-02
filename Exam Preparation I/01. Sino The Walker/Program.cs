using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputTime = Console.ReadLine();
            DateTime time = DateTime.ParseExact(inputTime, "H:m:s", CultureInfo.InvariantCulture);
            decimal steps = decimal.Parse(Console.ReadLine());
            decimal timeInSeconds = decimal.Parse(Console.ReadLine());
            decimal timeForStepsInHours = timeInSeconds * steps / 60 / 60;
            decimal timeWithoutDays = (timeForStepsInHours / 24);
            decimal resultInDays = timeWithoutDays - (long)timeWithoutDays;
            
            DateTime finalTime = time.AddDays((double)resultInDays);
            Console.WriteLine($"Time Arrival: {finalTime.TimeOfDay}");
        }
    }
}
