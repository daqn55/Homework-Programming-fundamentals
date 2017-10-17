using System;
using System.Collections.Generic;

namespace _03._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            int quantity = 0;
            if (resource != "stop")
            {
                quantity = int.Parse(Console.ReadLine());
            }

            Dictionary<string, int> data = new Dictionary<string, int>();
            while (resource != "stop")
            {
                if (data.ContainsKey(resource))
                {
                    data[resource] += quantity;
                }
                else
                {
                    data.Add(resource, quantity);
                }

                resource = Console.ReadLine();
                if (resource != "stop")
                {
                    quantity = int.Parse(Console.ReadLine());
                }
            }

            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
