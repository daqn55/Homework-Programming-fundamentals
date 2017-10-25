using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = File.ReadAllLines("Input.txt");
            File.WriteAllText("Output.txt", "");

            string resource = "";
            int quantity = 0;
            resource = inputs[0];
            if (resource != "stop")
            {
                quantity = int.Parse(inputs[1]);
            }

            int count = 2;
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
                resource = inputs[count];
                if (resource != "stop")
                {
                    quantity = int.Parse(inputs[count + 1]);
                }
                count += 2;

            }

            foreach (var item in data)
            {
                File.AppendAllText("Output.txt", $"{item.Key} -> {item.Value}\r\n");
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}