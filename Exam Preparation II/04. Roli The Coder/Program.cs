using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Coders
    {
        public string Id { get; set; }
        public string EventName { get; set; }
        public List<string> Participants { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Coders> events = new List<Coders>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Time for Code")
                {
                    break;
                }
                string[] data = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Coders coders = new Coders();

                if (data[1][0] == '#')
                {
                    if (events.Any(x => x.Id.Equals(data[0])) && events.Any(x => x.EventName.Equals(data[1])))
                    {
                        for (int i = 2; i < data.Length; i++)
                        {
                            foreach (var item in events.Where(x => x.EventName.Equals(data[1]) && x.Id.Equals(data[0])))
                            {
                                if (!item.Participants.Contains(data[i]))
                                {
                                    item.Participants.Add(data[i]);
                                }
                            }
                        }
                    }
                    else
                    {
                        bool containsId = false;
                        foreach (var item in events)
                        {
                            if (item.Id == data[0])
                            {
                                containsId = true;
                            }
                        }
                        if (!containsId)
                        {
                            coders.Id = data[0];
                            coders.EventName = data[1];
                            coders.Participants = new List<string>();
                            for (int i = 2; i < data.Length; i++)
                            {
                                if (!coders.Participants.Contains(data[i]))
                                {
                                    coders.Participants.Add(data[i]);
                                }
                            }
                            events.Add(coders);
                        }
                    }
                }

            }

            foreach (var item in events.OrderByDescending(x => x.Participants.Count).ThenBy(x => x.EventName))
            {
                Console.WriteLine($"{item.EventName.Substring(1)} - {item.Participants.Count}");
                foreach (var part in item.Participants.OrderBy(x => x))
                {
                    Console.WriteLine(part);
                }
            }
        }
    }
}
