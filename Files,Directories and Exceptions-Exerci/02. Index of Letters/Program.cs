using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _09._Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = File.ReadAllLines("Input.txt");
            File.WriteAllText("Output.txt", "");

            List<string> itemChar = new List<string>();
            List<int> itemCharInInt = new List<int>();

            foreach (var input in inputs)
            {
                char[] data = input.ToCharArray();

                foreach (var item in data)
                {
                    itemChar.Add(item.ToString());
                    itemCharInInt.Add((int)item - 97);
                }
            }
            for (int i = 0; i < itemChar.Count; i++)
            {

                File.AppendAllText("Output.txt", $"{itemChar[i]} -> {itemCharInInt[i]}\r\n");
            }
        }
    }
}
