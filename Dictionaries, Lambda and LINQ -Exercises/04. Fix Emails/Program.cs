using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string email = null;

            if (name != "stop")
            {
                email = Console.ReadLine();
            }

            Dictionary<string, string> personData = new Dictionary<string, string>();
            while (name != "stop")
            {
                string[] checkEmail = new string[2];
                checkEmail = email.Split('.').ToArray();

                if (checkEmail[1] != "us" && checkEmail[1] != "uk")
                {
                    personData.Add(name, email);
                }
                name = Console.ReadLine();
                if (name != "stop")
                {
                    email = Console.ReadLine();
                }
            }
            foreach (var item in personData)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
