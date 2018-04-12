using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputDrivers = Console.ReadLine().Split(new char[] { ' ' }
                                   , StringSplitOptions
                                   .RemoveEmptyEntries)
                                   .ToList();
            List<double> zone = Console.ReadLine().Split(new char[] { ' ' }
                                    , StringSplitOptions
                                    .RemoveEmptyEntries)
                                    .Select(double.Parse)
                                    .ToList();
            List<long> index = Console.ReadLine().Split(new char[] { ' ' }
                                    , StringSplitOptions
                                    .RemoveEmptyEntries)
                                    .Select(long.Parse)
                                    .ToList();

            foreach (var nameDriver in inputDrivers)
            {

                double letter = nameDriver[0];

                for (int i = 0; i < zone.Count; i++)
                {
                    bool YesZone = false;

                    if (index.Contains(i))
                    {
                        letter += zone[i];
                        YesZone = true;
                    }

                    if (YesZone == false)
                    {
                        letter -= zone[i];
                    }
                    if (letter <= 0)
                    {
                        Console.WriteLine("{0} - reached {1}", nameDriver, i);
                        goto startLine;
                    }
                }
                Console.WriteLine("{0} - fuel left {1:f2}", nameDriver, letter);
            startLine:
                continue;
            }
        }
    }
}
