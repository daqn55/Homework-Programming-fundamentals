using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            Dictionary<string, string> contacts = new Dictionary<string, string>();

            while (data != "END")
            {
                string[] newData = data.Split().ToArray();

                if (newData[0] == "A")
                {
                    if (contacts.ContainsKey(newData[1]))
                    {
                        contacts.Remove(newData[1]);
                        contacts.Add(newData[1], newData[2]);
                    }
                    else
                    {
                        contacts.Add(newData[1], newData[2]);
                    }
                }
                else if (newData[0] == "S")
                {
                    if (contacts.ContainsKey(newData[1]))
                    {
                        foreach (var item in contacts)
                        {
                            if (item.Key == newData[1])
                            {
                                Console.WriteLine($"{item.Key} -> {item.Value}");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Contact {newData[1]} does not exist.");
                    }
                }

                data = Console.ReadLine();
            }
        }
    }
}
