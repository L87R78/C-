using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var dicID = new Dictionary<int, Dictionary<string, List<string>>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input.Equals("Time for Code"))
                {
                    break;
                }
                var inputIDAndEventName = input.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                int ID = int.Parse(inputIDAndEventName[0]);
                string eventName = inputIDAndEventName[1];

                if (eventName[0] != '#')
                {
                    continue;
                }

                var inputNameParty = input.Split('@');
                                        
                var list = new List<string>();

                for (int i = 1; i < inputNameParty.Length; i++)
                {
                    list.Add(inputNameParty[i].Trim());
                }
           
                if (!dicID.ContainsKey(ID))
                {

                    dicID.Add(ID, new Dictionary<string, List<string>>());
                    dicID[ID][eventName] = new List<string>();
                    dicID[ID][eventName].AddRange(list);
                }
                else
                {
                    if (dicID[ID].ContainsKey(eventName))
                    {
                        dicID[ID][eventName].AddRange(list);
                    }
                }
            }
      
            var dicLenght = new Dictionary<string, List<string>>();
            foreach (var dic in dicID)
            {
                foreach (var ite in dic.Value)
                {
                    dicLenght[ite.Key] = new List<string>();
                    foreach (var it in ite.Value.Distinct())
                    {
                        dicLenght[ite.Key].Add(it);
                    }
                }
            }
            Console.WriteLine();
            foreach (var item in dicLenght.OrderBy(k => k.Key).OrderByDescending(v => v.Value.Count))
            {
                Console.WriteLine($"{item.Key.TrimStart('#')} - {item.Value.Count}");
                foreach (var ite in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine("@"+ite);
                }             
            }
        }
    }
}
