using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                           .Split(new char[] { ' ', ',' }
                           , StringSplitOptions
                           .RemoveEmptyEntries)
                           .Select(Demon.Parse)
                           .ToArray();

            Console.WriteLine();
            foreach (var item in input.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{item.Name} - {item.Health} health, {item.Demage:F2} damage ");
            }
        }
        class Demon
        {
            public string Name { get; set; }
            public decimal Health { get; set; }
            public decimal Demage { get; set; }

            public static Demon Parse(string DemonName)
            {
                var demon = new Demon();
                demon.Name = DemonName;

                demon.Health = CalculateHealth(DemonName);

                demon.Demage = CalculateDemage(DemonName);

                return demon;
            }

            private static decimal CalculateDemage(string DemonName)
            {
                var demagePattern = @"[+-]?\d+(?:\.?\d+)?";

                var demageSum = Regex.Matches(DemonName, demagePattern);

                var listDemage = new List<decimal>();
                foreach (Match match in demageSum)
                {
                    listDemage.Add(decimal.Parse(match.Value));
                }
                decimal resultDemage = listDemage.Sum();

                //result symbol
                var symbol = DemonName
                        .Where(s => s == '*' || s == '/')
                        .ToArray();

                foreach (var sumbo in symbol)
                {
                    switch (sumbo)
                    {
                        case '*':
                            resultDemage *= 2;
                            break;
                        case '/':
                            resultDemage /= 2;
                            break;
                    }
                }

                return resultDemage;
            }

            private static decimal CalculateHealth(string DemonName)
            {
                var healthPattern = @"[^0-9+\-*\/\.]";

                //var health = Regex.Matches(DemonName, healthRegex)
                //    .Cast<Match>()
                //    .Select(x => char.Parse(x.Value))
                //    .ToArray();

                var healthChars = Regex.Matches(DemonName, healthPattern);


                var listChars = new List<int>();
                foreach (Match match in healthChars)
                {
                    listChars.Add(char.Parse(match.Value));
                }
                long resultHealth = listChars.Sum();


                return resultHealth;
            }
        }
    }
}
