using System;
using System.Collections.Generic;
using System.Globalization;

namespace _01._Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)

        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            DateTime startDate = DateTime.ParseExact(date1, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(date2, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime[] holidays =
            {
                DateTime.ParseExact("01-01-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("03-03-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-09-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("22-09-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-11-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("25-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("26-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            };
            int count = 0;
            for (DateTime currentDay = startDate; currentDay <= endDate; currentDay = currentDay.AddDays(1))
            {
                
                bool isHoliday = false;

                foreach (var item in holidays)
                {

                    if (currentDay.Day == item.Day && currentDay.Month == item.Month)
                    {
                        isHoliday = true;
                        break;
                    }
                }
                if (!isHoliday)
                {
                    if (currentDay.DayOfWeek != DayOfWeek.Saturday && currentDay.DayOfWeek != DayOfWeek.Sunday)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
