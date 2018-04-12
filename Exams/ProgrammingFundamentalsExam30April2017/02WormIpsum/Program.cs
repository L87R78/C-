using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02WormIpsum
{
    class Program
    {
        static void Main(string[] args)
        {
            var listTotal = new List<string>();
            while (true)
            {

                string[] inputLine = Console.ReadLine()
                    .Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);


                if (inputLine[0] == "Worm Ipsum")
                {
                    break;
                }

                if (inputLine.Length > 1)
                {
                    continue;
                }

                string.Join(" ", inputLine[0]);

                string inputLineNew = inputLine[0].ToString();

                int count4 = 0;
                foreach (int item in inputLineNew)
                {
                    //string n = item.ToString();


                    if (item >= 65 && item <= 90)
                    {
                        break;
                    }
                    else
                    {
                        count4++;
                        break;
                    }
                }
                if (count4 >= 1)
                {
                    continue;
                }

                string[] inputLineNew2 = inputLineNew
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


                string result = "";
                var listFinish = new List<string>();
                foreach (var word in inputLineNew2)

                {
                    Dictionary<int, string> dic = new Dictionary<int, string>();

                    var list = new List<string>();
                    var listCountLetter = new List<string>();
                    foreach (var wor in word)
                    {
                        string temp = wor.ToString();
                        list.Add(temp);
                    }
                    int count = 0;


                    foreach (var ite in word)
                    {
                        bool test = false;
                        string temp2 = ite.ToString();
                        foreach (var lis in list)
                        {
                            if (lis == temp2)
                            {
                                count++;
                                continue;

                            }
                        }
                        if (count >= 2)
                        {
                            string letter = temp2;
                            if (!dic.ContainsKey(count))
                            {
                                dic.Add(count, null);
                                dic[count] = temp2;
                            }


                        }
                        count = 0;
                    }

                    if (dic.Count > 0)
                    {
                        foreach (var item in dic.OrderByDescending(x => x.Key))
                        {
                            string g = "";
                            for (int i = 0; i < word.Length; i++)
                            {
                                g += item.Value;
                            }
                            result += g + " ";
                            break;
                        }
                    }

                    else
                    {
                        result += word + " ";
                    }
                }
                result = result.Trim();
                listTotal.Add(result);
            }

            foreach (var item in listTotal)
            {
                Console.WriteLine(item + ".");
            }
        }
    }
}
