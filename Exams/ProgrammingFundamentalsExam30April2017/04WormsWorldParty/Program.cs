using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04WormsWorldParty
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> dic = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string[] inputLine = Console.ReadLine().Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                if (inputLine[0] == "quit")
                {
                    break;
                }
                bool test = false;
                string wormName = inputLine[0];
                string teamName = inputLine[1];
                long score = long.Parse(inputLine[2]);


                if (!dic.ContainsKey(teamName))
                {
                    dic.Add(teamName, new Dictionary<string, long>());
                    dic[teamName][wormName] = 0;
                    dic[teamName][wormName] = score;
                }
                else
                {
                    if (!dic[teamName].ContainsKey(wormName))
                    {


                        foreach (var item in dic.Values)
                        {
                            foreach (var ite in item)
                            {
                                if (ite.Key == wormName)
                                {
                                    test = true;
                                }
                            }
                        }
                        if (test == false)
                        {
                            dic[teamName][wormName] = score;
                        }

                    }
                }

            }

            Dictionary<string, long> dic2 = new Dictionary<string, long>();

            foreach (var item in dic)
            {
                foreach (var ite in item.Value)
                {
                    if (!dic2.ContainsKey(item.Key))
                    {
                        dic2.Add(item.Key, 0);
                        dic2[item.Key] = ite.Value;
                    }
                    else
                    {
                        dic2[item.Key] += ite.Value;
                    }
                }
            }

            int count = 0;

            Dictionary<string, Dictionary<string, long>> total = new Dictionary<string, Dictionary<string, long>>();

            foreach (var item in dic.OrderBy(x => x.Value.Count).OrderByDescending(y => y.Value.Values.Sum()))
            {
                count++;
                // OrderByDescending(x => x.Value.Count).OrderBy(y => y.Value.Values.Sum())

                Console.WriteLine($"{count}. Team:{item.Key}- {item.Value.Values.Sum()}");
                foreach (var ite in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{ite.Key}: {ite.Value}");
                }
            }
        }
    }
}
