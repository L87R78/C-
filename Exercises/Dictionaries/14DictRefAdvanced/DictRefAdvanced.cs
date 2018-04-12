namespace _14DictRefAdvanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DictRefAdvanced
    {
        public static void Main()
        {
            var dic = new Dictionary<string, List<int>>();
            while (true)
            {
                var inputLine = Console.ReadLine().Split(new char[] { '-','>' }, StringSplitOptions.RemoveEmptyEntries);

                string name = inputLine[0].Trim();
                if (name == "end")
                {
                    break;
                }
                var lastInput = inputLine[1].Split(new char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();
            
                int numbers;
                if (int.TryParse(lastInput[0], out numbers))
                {
                    List<int> list = lastInput.Select(int.Parse).ToList();
                    if (!dic.ContainsKey(name))
                    {
                        dic.Add(name, new List<int>());
                        dic[name].AddRange(list);
                    }
                    else
                    {
                        dic[name].AddRange(list);
                    }
                }
                else
                {
                    bool IsSearchNameInDic = false;
                    IsSearchNameInDic = dic.Keys.Any(x => x == lastInput[0]);

                    if (IsSearchNameInDic == true)
                    {
                        foreach (var item in dic)
                        {
                            if (item.Key == lastInput[0])
                            {
                                if (!dic.ContainsKey(name))
                                {
                                    dic.Add(name, new List<int>());
                                    dic[name].AddRange(item.Value);
                                    break;
                                }
                                else
                                {
                                    dic[name].AddRange(item.Value);
                                }
                            }
                        }
                    }
                }
            }
     
            foreach (var key in dic)
            {
                Console.WriteLine($"{key.Key} === {string.Join(", ",key.Value)}");
            }
       
        }
    }
}
