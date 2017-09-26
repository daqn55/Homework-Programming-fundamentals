using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            double groupSize = double.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double packagePrice = 0;
            double packageDiscount = 0;
            switch (package)
            {
                case "Normal":
                    packagePrice = 500;
                    packageDiscount = 0.95;
                    break;
                case "Gold":
                    packagePrice = 750;
                    packageDiscount = 0.90;
                    break;
                case "Platinum":
                    packagePrice = 1000;
                    packageDiscount = 0.85;
                    break;
                default:
                    break;
            }

            if (groupSize > 0 && groupSize <= 50)
            {
                Console.WriteLine("We can offer you the Small Hall");
                double pricePerPerson = ((2500 + packagePrice) * packageDiscount) / groupSize;
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                Console.WriteLine("We can offer you the Terrace");
                double pricePerPerson = ((5000 + packagePrice) * packageDiscount) / groupSize;
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                Console.WriteLine("We can offer you the Great Hall");
                double pricePerPerson = ((7500 + packagePrice) * packageDiscount) / groupSize;
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
