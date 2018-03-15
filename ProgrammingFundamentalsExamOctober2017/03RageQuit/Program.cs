using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03RageQuit
{
    class Program
    {
        static void Main()
        {
            string pattern = @"(\D+)(\d+)";
            Regex regex = new Regex(pattern);

            string inputLine = Console.ReadLine();
            MatchCollection matches = regex.Matches(inputLine);
            Console.WriteLine();
            var resultLenghtSymbol = "";
            StringBuilder resultText = new StringBuilder();

            foreach (Match match in matches)
            {
                var lenghtGroup = match.Groups[2].ToString();
                var lenghtGroupsNum = long.Parse(lenghtGroup);

                var text = match.Groups[1].ToString().ToUpper();
                for (int i = 0; i < lenghtGroupsNum; i++)
                {
                    resultText.Append(text);
                }
                if (lenghtGroupsNum <= 0)
                {
                    continue;
                }
                for (int i = 0; i < text.Length; i++)
                {
                    if (!resultLenghtSymbol.Contains(text[i]))
                    {
                        resultLenghtSymbol += text[i];
                    }
                }
            }
            Console.WriteLine($"Unique symbols used: {resultLenghtSymbol.Length}");
            Console.WriteLine(resultText);
        }
    }
}
