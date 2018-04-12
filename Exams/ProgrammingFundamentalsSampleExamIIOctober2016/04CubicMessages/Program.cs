using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04CubicMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "Over!")
                {
                    foreach (var item in dic)
                    {
                        Console.WriteLine($"{item.Key} == {item.Value}");
                    }

                    break;
                }
                int lenghtMassage = int.Parse(Console.ReadLine());
                string pattern = @"^(\d+)([a-zA-Z]+)([^a-zA-Z]+)?$";

                Regex regex = new Regex(pattern);

                MatchCollection matches = regex.Matches(inputLine);

                foreach (Match match in matches)
                {
                    if (match.Groups[2].Length == lenghtMassage)
                    {
                        string result = "";
                        bool noDigits = true;
                        if (match.Groups[2].Length == lenghtMassage)
                        {
                            foreach (var num in match.Groups[1].Value)
                            {
                                bool digit = char.IsDigit(num);

                                if (digit == true)
                                {

                                }
                                else
                                {
                                    noDigits = false;
                                }


                            }

                            if (noDigits == true)
                            {
                                var listText = new List<string>();
                                for (int i = 0; i < match.Groups[2].Value.Length; i++)
                                {
                                    string letter = match.Groups[2].Value[i].ToString();
                                    listText.Add(letter);
                                }


                                for (int a = 0; a < match.Groups[1].Value.Length; a++)
                                {
                                    string str = match.Groups[1].Value[a].ToString();
                                    int n = int.Parse(str);
                                    bool bol = false;
                                    for (int b = 0; b < listText.Count; b++)
                                    {
                                        if (n == b)
                                        {
                                            result += listText[b];
                                            bol = true;
                                            break;
                                        }
                                    }
                                    if (bol == false)
                                    {
                                        result += " ";
                                    }
                                }

                                for (int a = 0; a < match.Groups[3].Value.Length; a++)
                                {
                                    string str = match.Groups[3].Value[a].ToString();

                                    if (str != "1" && str != "2" && str != "3" && str != "4" && str != "5" && str != "6" &&
                                        str != "7" && str != "8" && str != "9" && str != "0")
                                    {
                                        result += " ";
                                        continue;
                                    }
                                    int n = int.Parse(str);
                                    bool bol = false;
                                    for (int b = 0; b < listText.Count; b++)
                                    {
                                        if (n == b)
                                        {
                                            result += listText[b];
                                            bol = true;
                                            break;
                                        }
                                    }
                                    if (bol == false)
                                    {
                                        result += " ";
                                    }
                                }

                                if (!dic.ContainsKey(match.Groups[2].Value))
                                {
                                    dic.Add(match.Groups[2].Value, null);
                                    dic[match.Groups[2].Value] = result;
                                }


                            }
                        }
                    }

                }

            }
        }
    }
}
