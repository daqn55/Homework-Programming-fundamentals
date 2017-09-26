using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;
            int count = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (peshoHealth <= 0)
                {
                    Console.WriteLine($"Gosho won in {count}th round.");
                    break;
                }
                else if (goshoHealth <= 0)
                {
                    Console.WriteLine($"Pesho won in {count}th round.");
                    break;
                }
                else
                {
                    if (i % 2 != 0)
                    {
                        goshoHealth -= peshoDamage;
                        if (!(goshoHealth <= 0))
                        {
                            Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                        }
                    }
                    else
                    {
                        peshoHealth -= goshoDamage;
                        if (!(peshoHealth <= 0))
                        {
                            Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                        }
                    }
                    if (i % 3 == 0 && goshoHealth > 0 && peshoHealth > 0)
                    {
                        peshoHealth += 10;
                        goshoHealth += 10;
                    }
                }
                count++;
            }
        }
    }
}
