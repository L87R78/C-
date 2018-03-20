using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            var dicMessage = new Dictionary<string, List<string>>();
            var dicBroadcasts = new Dictionary<string, List<string>>();
            while (true)
            {
                var inputLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (inputLine[0] == "Hornet")
                {
                    break;
                }
                string firstCommand = inputLine[0];
                string secondCommnad = inputLine[2];

                // searchDigits
                int countDigits = 0;
                int countNoDigits = 0;
                foreach (var letter in firstCommand)
                {
                    bool digits = char.IsDigit(letter);

                    if (digits == true)
                    {
                        countNoDigits++;
                    }
                    else
                    {
                        countDigits++;
                    }
                }

                if (countDigits == 0)
                {
                    int count = 0;
                    foreach (var letter in secondCommnad)
                    {
                        bool IsSearchDigtsAndLetters = char.IsLetterOrDigit(letter);
                        if (IsSearchDigtsAndLetters == true)
                        {

                        }
                        else
                        {
                            count++;
                        }
                    }

                    if (count == 0)
                    {
                        firstCommand = String.Concat(firstCommand.Reverse());
                        string temp = firstCommand + " -> " + secondCommnad;
                        if (!dicMessage.ContainsKey("Messages:"))
                        {
                            dicMessage.Add("Messages:", new List<string>());
                            dicMessage["Messages:"].Add(temp);
                        }
                        else
                        {
                            dicMessage["Messages:"].Add(temp);
                        }
                    }
                }
                else if (countNoDigits == 0)
                {
                    int count = 0;
                    foreach (var letter in secondCommnad)
                    {
                        bool IsSearchDigtsAndLetters = char.IsLetterOrDigit(letter);
                        if (IsSearchDigtsAndLetters == true)
                        {

                        }
                        else
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        string temp = "";

                        foreach (var letter in secondCommnad)
                        {

                            if (letter >= 65 && letter <= 90)
                            {
                                temp += (char)(letter + 32);
                            }
                            else if (letter >= 97 && letter <= 122)
                            {
                                temp += (char)(letter - 32);
                            }
                            else
                            {
                                temp += letter;
                            }
                        }

                        temp = temp + " -> " + firstCommand;

                        if (!dicBroadcasts.ContainsKey("Broadcasts:"))
                        {
                            dicBroadcasts.Add("Broadcasts:", new List<string>());
                            dicBroadcasts["Broadcasts:"].Add(temp);
                        }
                        else
                        {
                            dicBroadcasts["Broadcasts:"].Add(temp);
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Broadcasts:");
            if (dicBroadcasts.Count > 0)
            {
                foreach (var key in dicBroadcasts)
                {
                    foreach (var value in key.Value)
                    {
                        Console.WriteLine(value);
                    }
                }
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (dicMessage.Count > 0)
            {
                foreach (var key in dicMessage)
                {
                    foreach (var value in key.Value)
                    {
                        Console.WriteLine(value);
                    }
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
