using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> beehives = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(BigInteger.Parse).ToList();
            List<BigInteger> hornets = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(BigInteger.Parse).ToList();


            List<BigInteger> liveBees = new List<BigInteger>();
            BigInteger hornetsPower = 0;

            for (int i = 0; i < hornets.Count; i++)
            {
                hornetsPower += hornets[i];
            }

            for (int i = 0; i < beehives.Count; i++)
            {
                if (beehives[i] >= hornetsPower)
                {
                    if (beehives[i] - hornetsPower != 0)
                    {
                        liveBees.Add(beehives[i] - hornetsPower);
                    }
                    if (hornets.Count != 0)
                    {
                        hornetsPower -= hornets[0];
                    }
                    if (hornets.Count > 0)
                    {
                        hornets.RemoveAt(0);
                    }
                }
            }

            if (liveBees.Count > 0)
            {
                Console.WriteLine(string.Join(" ", liveBees));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
