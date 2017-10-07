using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_of_Week
{
    class Program
    {
        static string DayOfWeek(int n)
        {
            string[] weekDays = {"Monday", "Tuesday", "Wednesday", "Thursday",
            "Friday", "Saturday", "Sunday"};
            string currentDay = weekDays[n];
            return currentDay;

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n >= 1 && n <= 7)
            {
                Console.WriteLine(DayOfWeek(n - 1));
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
