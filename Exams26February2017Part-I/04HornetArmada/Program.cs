namespace _04HornetArmada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, long>> dicSoldier =
                new Dictionary<string, Dictionary<string, long>>();

            Dictionary<string, long> soldierType =
               new Dictionary<string, long>();
            long numAcivity = 0;
            for (int i = 0; i < n; i++)
            {
                string inputLine = Console.ReadLine();
                string[] splitInput = inputLine.Split(new char[] { ' ', ':' }
                                                    , StringSplitOptions
                                                        .RemoveEmptyEntries);

                long activity = long.Parse(splitInput[0]);
                string legionName = splitInput[2];
                string legionType = splitInput[4];
                long soldierCount = long.Parse(splitInput[5]);

                //result soldier
                if (!dicSoldier.ContainsKey(legionType))
                {
                    dicSoldier.Add(legionType, new Dictionary<string, long>());
                    dicSoldier[legionType][legionName] = 0;
                    dicSoldier[legionType][legionName] = soldierCount;
                }
                else
                {
                    if (!dicSoldier[legionType].ContainsKey(legionName))
                    {
                        dicSoldier[legionType][legionName] = soldierCount;
                    }
                    else
                    {
                        dicSoldier[legionType][legionName] += soldierCount;
                    }
                }

                // result soldierType
                if (!soldierType.ContainsKey(legionName))
                {
                    soldierType.Add(legionName, 0);
                    soldierType[legionName] = activity;
                    foreach (var item in soldierType)
                    {
                        numAcivity = item.Value;
                    }
                }
                else
                {
                    if (activity > numAcivity)
                    {
                        soldierType[legionName] = activity;
                        foreach (var item in soldierType)
                        {
                            numAcivity = activity;
                        }
                    }
                }
            }

            string[] endCommand = Console.ReadLine().Split('\\');
            if (endCommand.Length == 1)
            {
                foreach (var item in soldierType.OrderByDescending(v => v.Value))
                {
                    Console.WriteLine($"{item.Value} : {item.Key}");
                    //todo...?
                }
            }
            else
            {
                foreach (var soldier in dicSoldier)
                {
                    string soldierStr = endCommand[1];
                    int max = int.Parse(endCommand[0]);
                    if (soldier.Key == soldierStr)
                    {
                        foreach (var solValue in soldier.Value.OrderBy(x => x.Key).OrderByDescending(y => y.Value))
                        {
                            foreach (var type in soldierType)
                            {
                                if (solValue.Key == type.Key)
                                {
                                    if (type.Value < max)
                                    {
                                        Console.WriteLine($"{solValue.Key} -> {solValue.Value}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
