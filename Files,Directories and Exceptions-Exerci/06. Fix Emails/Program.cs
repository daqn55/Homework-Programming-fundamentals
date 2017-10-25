using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04._Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = File.ReadAllLines("Input.txt");
            File.WriteAllText("Output.txt", "");

            string name = inputs[0];
            string email = null;

            if (name != "stop")
            {
                email = inputs[1];
            }

            int count = 2;
            Dictionary<string, string> personData = new Dictionary<string, string>();
            while (name != "stop")
            {
                string[] checkEmail = new string[2];
                checkEmail = email.Split('.').ToArray();

                if (checkEmail[1] != "us" && checkEmail[1] != "uk")
                {
                    personData.Add(name, email);
                }
                name = inputs[count];
                if (name != "stop")
                {
                    email = inputs[count + 1];
                }
                count += 2;
            }
            foreach (var item in personData)
            {
                File.AppendAllText("Output.txt", $"{item.Key} -> {item.Value}\r\n");
            }
        }
    }
}