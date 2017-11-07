using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            decimal totalLoss = 0;
            List<string> sites = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                sites.Add(data[0]);
                totalLoss += decimal.Parse(data[1]) * decimal.Parse(data[2]);
            }
            BigInteger securityToken = 1;
            for (int i = 0; i < n; i++)
            {
                securityToken *= securityKey;
            }

            foreach (var item in sites)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
