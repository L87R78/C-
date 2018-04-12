namespace _03RoliTheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            Dictionary<int, Dictionary<string,string>> dic = new Dictionary<int, Dictionary<string, string>>();
            while (true)
            {
                var inputLIne = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (inputLIne[0] == "Time")
                {
                    break;
                }

                int ID = int.Parse(inputLIne[0]);
                string name = inputLIne[1];
                string participant = "";
                bool test = true;
                for (int i = 2; i < inputLIne.Length; i++)
                {
                    foreach (var letter in inputLIne[i])
                    {
                        string tempLet = letter.ToString();
                        if (tempLet == "@")
                        {
                             participant += inputLIne[i] + " ";
                            break;
                        }
                        else
                        {
                            test = false;
                            break;
                        }
                    }
                    if (test == false)
                    {
                        break;
                    }
                   
                }

                if (test == false)
                {
                    continue;
                }

                foreach (var item in name)
                {
                    string temp = item.ToString();
                    if (temp == "#")
                    {
                        if (!dic.ContainsKey(ID))
                        {
                            dic.Add(ID, new Dictionary<string, string>());
                            dic[ID][name] = participant;
                        }
                        else
                        {
                            if (dic[ID].ContainsKey(name))
                            {
                                dic[ID][name] += participant;
                            }
                        }
                    }
                    else
                    {
                        
                        break;
                    }
                }   
            }

            Dictionary<string, List<string>> dicFinish = new Dictionary<string, List<string>>();

            foreach (var item in dic)
            {
                foreach (var ite in item.Value)
                {
                    List<string> listTemp = ite.Value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();

                    if (!dicFinish.ContainsKey(ite.Key))
                    {
                        dicFinish.Add(ite.Key, new List<string>());
                        foreach (var it in listTemp)
                        {
                            dicFinish[ite.Key].Add(it);
                        }
                        
                    }
                }
            }
         
            Dictionary<string, string> kur = new Dictionary<string, string>();
            foreach (var item in dicFinish.OrderBy(x => x.Key).OrderByDescending(x => x.Value.Count()))
            {
                Console.WriteLine($"{item.Key.Trim('#')} - {item.Value.Count}");
              
                foreach (var ite in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine(ite);
                }
            
            }
        }
    }
}
