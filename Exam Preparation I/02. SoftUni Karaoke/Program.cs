using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participant = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string[] songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, Dictionary<string, string>> personWithAwards = new Dictionary<string, Dictionary<string, string>>(); 
            while (true)
            {
                string performance = Console.ReadLine();
                if (performance == "dawn")
                {
                    break;
                }
                string[] currentOnStage = performance.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                
                if (participant.Contains(currentOnStage[0]))
                {
                    if (songs.Contains(currentOnStage[1]))
                    {
                        if (personWithAwards.ContainsKey(currentOnStage[0]))
                        {
                            if (!personWithAwards[currentOnStage[0]].ContainsKey(currentOnStage[2]))
                            {
                                personWithAwards[currentOnStage[0]].Add(currentOnStage[2], currentOnStage[1]);
                            }
                        }
                        else
                        {
                            personWithAwards.Add(currentOnStage[0], new Dictionary<string, string>());
                            personWithAwards[currentOnStage[0]].Add(currentOnStage[2], currentOnStage[1]);
                        }
                    }
                }
            }
            if (personWithAwards.Count > 0)
            {
                foreach (var item in personWithAwards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{item.Key}: {item.Value.Count} awards");
                    foreach (var aw in item.Value.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"--{aw.Key}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
            
        }
    }
}
