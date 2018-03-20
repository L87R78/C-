using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputName = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] allowedSong = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "dawn")
                {
                    break;
                }
                string[] inputSplit = inputLine.Split(',');

                foreach (var name in inputName)
                {
                    if (name == inputSplit[0])
                    {
                        if (!dic.ContainsKey(inputSplit[0]))
                        {
                            dic.Add(name, new List<string>());
                            foreach (var allowed in allowedSong)
                            {
                                if (allowed.TrimStart() == inputSplit[1].TrimStart())
                                {
                                    dic[name].Add(inputSplit[2].TrimStart());
                                    break;
                                }
                            }
                        }
                        else
                        {
                            foreach (var allowed in allowedSong)
                            {
                                if (allowed.TrimStart() == inputSplit[1].TrimStart())
                                {
                                    dic[name].Add(inputSplit[2].TrimStart());
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            Dictionary<string, List<string>> dicOutput = new Dictionary<string, List<string>>();

            foreach (var di in dic)
            {
                List<string> listDistinct = di.Value.Distinct().ToList();

                if (!dicOutput.ContainsKey(di.Key))
                {
                    dicOutput.Add(di.Key, new List<string>());

                    foreach (var value in listDistinct)
                    {
                        dicOutput[di.Key].Add(value);
                    }
                }
            }

            if (dic.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }
            Console.WriteLine();
            foreach (var item in dicOutput.OrderBy(x => x.Key).OrderByDescending(y => y.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count} awards");
                foreach (var value in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"--{value}");
                }
            }
        }
    }
}
