namespace _04DecryptTheMessages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class DecryptTheMessages
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            List<string> list = new List<string>();
            
            while (true)
            {
                while (start == "START" || start == "start")
                {
                    string text = Console.ReadLine();
                    if (text == string.Empty)
                    {
                        continue;
                    }
                    if (text == "END" || text == "end")
                    {
                        if (list.Count == 0)
                        {
                            Console.WriteLine("No message received.");
                            return;
                        }

                        Console.WriteLine($"Total number of messages: {list.Count}");           
                        foreach (var word in list)
                        {
                            word.Reverse();
                            Console.WriteLine(word);
                        }
                        return;                          
                    }
                    string temporarity = string.Empty;
                    for (int i = 0; i < text.Length; i++)
                    {
                        int letter = text[i];
                        if (letter == '+')
                        {
                            temporarity += " ";
                        }
                        else if (letter == '%')
                        {
                            temporarity += ",";
                        }
                        else if (letter == '&')
                        {
                            temporarity += ".";
                        }
                        else if (letter == '$')
                        {
                            temporarity += "!";
                        }
                        else if (letter == '#')
                        {
                            temporarity += "?";
                        }
                        else if (letter >= '0' && letter <= '9')
                        {
                            temporarity += letter - '0';
                        }
                        else if (letter >= 'A' && letter <= 'M' || letter >= 'a' && letter <= 'm')
                        {
                            temporarity += (char)(letter + 13);
                        }
                        else if (letter >= 'N' && letter <= 'Z' || letter >= 'n' && letter <= 'z')
                        {
                            temporarity += (char)(letter - 13);
                        }
                    }
                    temporarity = String.Concat(temporarity.Reverse());
                    list.Add(temporarity);
                }
                start = Console.ReadLine();
            }   
        }
    }
}
