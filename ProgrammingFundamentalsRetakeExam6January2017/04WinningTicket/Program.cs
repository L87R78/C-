using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine()
                                .Split(new[] { ' ', ',' }
                                , StringSplitOptions
                                .RemoveEmptyEntries)
                                .ToArray();

            foreach (var text in inputLine)
            {
                string str = text;
                var leftList = new List<string>();
                var rightList = new List<string>();

                if (text.Length == 20)
                {
                    resultLeft(text, ref str, ref leftList);
                    resultRight(text, ref str, ref rightList);

                    if (leftList.Count < 6 || rightList.Count < 6
                        || leftList[0] != rightList[0])
                    {
                        Console.WriteLine($"ticket \"{text}\" - no match");
                        continue;
                    }

                    if (leftList.Count == 10 && rightList.Count == 10)
                    {
                        Console.WriteLine($"ticket \"{text}\" - {leftList.Count}{leftList[0]} Jackpot!");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{text}\" - {Math.Min(leftList.Count, rightList.Count)}{leftList[0]}");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
            }
        }

        private static void resultRight(string text, ref string str, ref List<string> rightList)
        {
            int countRight = 0;
            int countLoop = 1;
            int lenghtLoop = 0;
            str = String.Concat(str.Reverse());
            for (int i = 0; i < text.Length / 2; i++)
            {
                if (str[i] == '$' || str[i] == '@' || str[i] == '#' || str[i] == '^')
                {
                    if (countLoop >= lenghtLoop)
                    {
                        lenghtLoop = countLoop;
                        rightList.Add(str[i].ToString());
                    }
                    else
                    {
                        countLoop = 1;
                    }

                }
                else
                {
                    if (rightList.Count >= 6)
                    {
                        break;
                    }
                    countLoop = 1;
                    lenghtLoop = 0;
                    rightList = new List<string>();
                }

            }

            for (int i = 0; i < rightList.Count; i++)
            {

                string letter = rightList[0];
                if (letter == rightList[i])
                {
                    countRight++;
                }
                else if (countRight >= 6)
                {
                    for (int k = rightList.Count - 1; k >= i; k--)
                    {
                        rightList.RemoveAt(k);
                    }
                }
                else if (countRight < 6)
                {
                    for (int remove = 0; remove < countRight; remove++)
                    {
                        rightList.RemoveAt(0);
                    }
                    countRight = 0;
                }
            }
        }

        private static void resultLeft(string text, ref string str, ref List<string> leftList)
        {
            int countLeft = 0;
            int countLoop = 1;
            int lenghtLoop = 0;
            for (int i = 0; i < text.Length / 2; i++)
            {
                if (str[i] == '$' || str[i] == '@' || str[i] == '#' || str[i] == '^')
                {
                    if (countLoop >= lenghtLoop)
                    {
                        lenghtLoop = countLoop;
                        leftList.Add(str[i].ToString());
                    }
                    else
                    {
                        countLoop = 1;
                    }

                }
                else
                {
                    if (leftList.Count >= 6)
                    {
                        break;
                    }
                    countLoop = 1;
                    lenghtLoop = 0;
                    leftList = new List<string>();
                }
            }

            for (int i = 0; i < leftList.Count; i++)
            {
                string letter = leftList[0];
                if (letter == leftList[i])
                {
                    countLeft++;
                }
                else if (countLeft >= 6)
                {
                    for (int k = i; k <= leftList.Count + 1; k++)
                    {
                        leftList.RemoveAt(i);
                    }
                }
                else if (countLeft < 6)
                {
                    for (int remove = 0; remove < countLeft; remove++)
                    {
                        leftList.RemoveAt(0);
                    }
                    countLeft = 0;
                }
            }
        }
    }
}
