using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.Write("Health: ");
            Console.Write("|");
            if (currentHealth == 0)
            {
                Console.Write(new string('.', maxHealth));
            }
            else
            {
                int oddHealth = maxHealth - currentHealth;
                Console.Write(new string('|', currentHealth));
                Console.Write(new string('.', oddHealth));
            }
            Console.WriteLine("|");

            Console.Write("Energy: ");
            Console.Write("|");
            if (currentEnergy == 0)
            {
                Console.Write(new string('.', maxEnergy));
            }
            else
            {
                int oddEnergy = maxEnergy - currentEnergy;
                Console.Write(new string('|', currentEnergy));
                Console.Write(new string('.', oddEnergy));
            }
            Console.WriteLine("|");

        }
    }
}
