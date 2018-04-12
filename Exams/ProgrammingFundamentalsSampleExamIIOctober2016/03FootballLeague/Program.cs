using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> dicLeague = new Dictionary<string, long>();
            Dictionary<string, long> dicScore = new Dictionary<string, long>();


            string key = Console.ReadLine();

            while (true)
            {
                string[] inputLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (inputLine[0] == "final" || inputLine[0] == "FINAL")
                {
                    break;
                }

                string firstLine = inputLine[0];
                string secindLine = inputLine[1];


                //result first team
                int firstKey = firstLine.IndexOf(key);
                int secondKey = firstLine.LastIndexOf(key);

                string firstTeam = firstLine.Substring(firstKey + key.Length, secondKey - (firstKey + key.Length));
                firstTeam = String.Concat(firstTeam.Reverse()).ToUpper();

                //result second team
                int firstKey2 = secindLine.IndexOf(key);
                int secondKey2 = secindLine.LastIndexOf(key);

                string secondTeam = secindLine.Substring(firstKey2 + key.Length, secondKey2 - (firstKey2 + key.Length));
                secondTeam = String.Concat(secondTeam.Reverse()).ToUpper();

                bool wordLeft1 = true;
                bool wordRight1 = true;
                foreach (var item in firstTeam)
                {
                    if (item >= 'A' && item <= 'Z')
                    {

                    }
                    else
                    {
                        wordLeft1 = false;
                    }
                }
                if (wordLeft1 == false)
                {
                    continue;
                }

                foreach (var item in secondTeam)
                {
                    if (item >= 'A' && item <= 'Z')
                    {

                    }
                    else
                    {
                        wordRight1 = false;
                    }
                }
                if (wordRight1 == false)
                {
                    continue;
                }



                string[] scoreArr = inputLine[2].Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
                int leftScore = int.Parse(scoreArr[0]);
                int rightScore = int.Parse(scoreArr[1]);



                if (leftScore > rightScore)
                {
                    //league
                    if (!dicLeague.ContainsKey(firstTeam))
                    {
                        dicLeague.Add(firstTeam, 0);
                        dicLeague[firstTeam] = 3;
                    }
                    else
                    {
                        dicLeague[firstTeam] += 3;
                    }


                    if (!dicLeague.ContainsKey(secondTeam))
                    {
                        dicLeague.Add(secondTeam, 0);
                        dicLeague[secondTeam] = 0;
                    }
                    else
                    {
                        dicLeague[secondTeam] += 0;
                    }

                }
                else if (leftScore < rightScore)
                {
                    if (!dicLeague.ContainsKey(secondTeam))
                    {
                        dicLeague.Add(secondTeam, 0);
                        dicLeague[secondTeam] = 3;
                    }
                    else
                    {
                        dicLeague[secondTeam] += 3;
                    }


                    if (!dicLeague.ContainsKey(firstTeam))
                    {
                        dicLeague.Add(firstTeam, 0);
                        dicLeague[firstTeam] = 0;
                    }
                    else
                    {
                        dicLeague[firstTeam] += 0;
                    }

                }
                else
                {
                    if (!dicLeague.ContainsKey(firstTeam))
                    {
                        dicLeague.Add(firstTeam, 0);
                        dicLeague[firstTeam] = 1;
                    }
                    else
                    {
                        dicLeague[firstTeam] += 1;
                    }

                    if (!dicLeague.ContainsKey(secondTeam))
                    {
                        dicLeague.Add(secondTeam, 0);
                        dicLeague[secondTeam] = 1;
                    }
                    else
                    {
                        dicLeague[secondTeam] += 1;
                    }

                }

                if (!dicScore.ContainsKey(firstTeam))
                {
                    dicScore.Add(firstTeam, 0);
                    dicScore[firstTeam] = leftScore;
                }
                else
                {
                    dicScore[firstTeam] += leftScore;
                }

                if (!dicScore.ContainsKey(secondTeam))
                {
                    dicScore.Add(secondTeam, 0);
                    dicScore[secondTeam] = rightScore;
                }
                else
                {
                    dicScore[secondTeam] += rightScore;
                }
            }

            Console.WriteLine("League standings:");
            int count = 1;
            foreach (var item in dicLeague.OrderBy(x => x.Key).OrderByDescending(y => y.Value))
            {
                Console.WriteLine($"{count}. {item.Key} {item.Value}");
                count++;
            }
            Console.WriteLine("Top 3 scored goals:");

            foreach (var item in dicScore.OrderBy(y => y.Key).OrderByDescending(x => x.Value).Take(3))
            {
                Console.WriteLine($"- {item.Key} -> {item.Value}");
            }
        }
    }
}
