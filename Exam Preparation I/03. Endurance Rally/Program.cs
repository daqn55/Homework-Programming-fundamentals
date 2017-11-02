using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] drivers = Console.ReadLine().Split();
            double[] zones = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] checkpoints = Console.ReadLine().Split().Select(double.Parse).ToArray();

            int countWhichItemWeHave = 0;
            List<KeyValuePair<string, Dictionary<string, double>>> reachedOrFluelLeft = new List<KeyValuePair<string, Dictionary<string, double>>>();
            foreach (var item in drivers)
            {
                double fluel = item[0];
                int count = 0;
                for (int i = 0; i < zones.Length; i++)
                {
                    bool chargeFluel = false;
                    for (int y = 0; y < checkpoints.Length; y++)
                    {
                        if (i == checkpoints[y] && checkpoints[y] >= 0)
                        {
                            fluel += zones[i];
                            chargeFluel = true;
                            break;
                        }
                    }
                    if (!chargeFluel)
                    {
                        fluel -= zones[i];
                    }
                    if (fluel <= 0)
                    {
                        reachedOrFluelLeft.Add(new KeyValuePair<string, Dictionary<string, double>>(item, new Dictionary<string, double>()));
                        reachedOrFluelLeft[countWhichItemWeHave].Value.Add("reached", count);
                        break;
                    }
                    else
                    {
                        count++;
                    }
                }
                if (fluel > 0)
                {
                    reachedOrFluelLeft.Add(new KeyValuePair<string, Dictionary<string, double>>(item, new Dictionary<string, double>()));
                    reachedOrFluelLeft[countWhichItemWeHave].Value.Add("fuel left", fluel);
                }
                countWhichItemWeHave++;
            }
            foreach (var item in reachedOrFluelLeft)
            {
                if (item.Value.Keys.First().Equals("fuel left"))
                {
                    Console.WriteLine($"{item.Key} - {item.Value.Keys.First()} {item.Value.Values.First():f2}");
                }
                else
                {
                    Console.WriteLine($"{item.Key} - {item.Value.Keys.First()} {item.Value.Values.First()}");
                }
            }
        }
    }
}
