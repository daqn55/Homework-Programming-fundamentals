using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hornet_Armada
{
    class SoldiersInfo
    {
        public int LastActivity { get; set; }
        public string LegionName { get; set; }
        public Dictionary<string, long> SoldierTypeAndCount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<SoldiersInfo> soldiersInfo = new List<SoldiersInfo>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(new string[] { " = ", " -> ", ":"}, StringSplitOptions.RemoveEmptyEntries);
                SoldiersInfo soldiers = new SoldiersInfo();
                soldiers.SoldierTypeAndCount = new Dictionary<string, long>();
                if (soldiersInfo.Any(x => x.LegionName.Equals(data[1])))
                {
                    foreach (var item in soldiersInfo)
                    { 
                        if (item.LegionName.Equals(data[1]))
                        {
                            if (item.LastActivity < int.Parse(data[0]))
                            {
                                item.LastActivity = int.Parse(data[0]);
                            }
                            if (item.SoldierTypeAndCount.ContainsKey(data[2]))
                            {
                                item.SoldierTypeAndCount[data[2]] += long.Parse(data[3]);
                            }
                            else
                            {
                                item.SoldierTypeAndCount.Add(data[2], long.Parse(data[3]));
                            }
                            break;
                        }
                    }
                }
                else
                {
                    soldiers.LastActivity = int.Parse(data[0]);
                    soldiers.LegionName = data[1];
                    soldiers.SoldierTypeAndCount.Add(data[2], long.Parse(data[3]));
                    soldiersInfo.Add(soldiers);
                }
            }
            string[] commands = Console.ReadLine().Split('\\').ToArray();
            string soldierType;
            if (commands.Length > 1)
            {
                Dictionary<string, long> result = new Dictionary<string, long>();
                int activity = int.Parse(commands[0]);
                soldierType = commands[1];
                foreach (var item in soldiersInfo.Where(x => x.LastActivity < activity 
                && x.SoldierTypeAndCount.ContainsKey(soldierType)))
                {
                    result.Add(item.LegionName, 0);
                    foreach (var sl in item.SoldierTypeAndCount.Where(x => x.Key == soldierType))
                    {
                        result[item.LegionName] = sl.Value;
                    }
                }
                foreach (var item in result.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
            else
            {
                soldierType = commands[0];
                Dictionary<string, int> result = new Dictionary<string, int>();
                foreach (var item in soldiersInfo.Where(x => x.SoldierTypeAndCount.ContainsKey(soldierType)))
                {
                    result.Add(item.LegionName, item.LastActivity);
                }
                foreach (var item in result.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{item.Value} : {item.Key}");
                }
            }
        }
    }
}
