using System;
using System.Globalization;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();


            Console.WriteLine(DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture).DayOfWeek);
        }
    }
}
