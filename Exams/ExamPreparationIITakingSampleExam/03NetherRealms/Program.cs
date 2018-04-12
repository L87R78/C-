using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var text in inputLine.OrderBy(x => x))
            {
                long health = 0;
                StringBuilder temp = new StringBuilder();
                foreach (char letter in text)
                {
                    bool digit = char.IsDigit(letter);

                    if (digit == false && letter != '.' && letter != '*' && letter != '-' && letter != '+' && letter != '/')
                    {
                        health += (int)letter;
                    }
                    else if (letter == '*' || letter == '/')
                    {
                        temp.Append(letter);
                    }

                }
                double demage = 0;
                StringBuilder digitSb = new StringBuilder();

                foreach (var digit in text)
                {
                    if (digit >= '0' && digit <= '9' || digit == '-')
                    {
                        digitSb.Append(digit);
                    }
                    else if (digit == '.')
                    {
                        digitSb.Append(digit);
                    }
                    else
                    {
                        digitSb.Append(" ");
                    }
                }

                string result = digitSb.ToString();

                List<string> list = result.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                foreach (var item in list)
                {
                    demage += double.Parse(item);
                }

                string tempNew = temp.ToString();
                foreach (var symbol in tempNew)
                {
                    if (symbol == '*')
                    {
                        demage *= 2;
                    }
                    else if (symbol == '/')
                    {
                        demage /= 2;
                    }

                }
                Console.WriteLine($"{text} - {health} health, {demage:F2} damage");
            }
        }
    }
}
