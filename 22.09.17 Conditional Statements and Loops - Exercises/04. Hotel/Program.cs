using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());

            double studio = 0;
            double doubleRoom = 0;
            double suite = 0;
            double studioNights = nights;

            
            switch (month)
            {
                case "May":
                    if (nights > 7)
                    {
                        studio = 50 * 0.95;
                    }
                    else
                    {
                        studio = 50;
                    }
                    doubleRoom = 65;
                    suite = 75;
                    break;
                case "October":
                    if (nights > 7)
                    {
                        studioNights--;
                        studio = 50 * 0.95;
                    }
                    else
                    {
                        studio = 50;
                    }
                    doubleRoom = 65;
                    suite = 75;
                    break;
                case "June":
                    if (nights > 14)
                    {
                        doubleRoom = 72 * 0.90;
                    }
                    else
                    {
                        doubleRoom = 72;
                    }
                    studio = 60;
                    suite = 82;
                    break;
                case "September":
                    if (nights > 7)
                    {
                        studioNights--;
                    }
                    if (nights > 14)
                    {
                        doubleRoom = 72 * 0.9;
                    }
                    else
                    {
                        doubleRoom = 72;
                    }
                    studio = 60;
                    suite = 82;
                    break;
                default:
                    if (nights > 14)
                    {
                        suite = 89 * 0.85;
                    }
                    else
                    {
                        suite = 89;
                    }
                    studio = 68;
                    doubleRoom = 77;
                    break;
            }
            Console.WriteLine($"Studio: {studio * studioNights:f2} lv.");
            Console.WriteLine($"Double: {doubleRoom * nights:f2} lv.");
            Console.WriteLine($"Suite: {suite * nights:f2} lv.");
        }
    }
}
