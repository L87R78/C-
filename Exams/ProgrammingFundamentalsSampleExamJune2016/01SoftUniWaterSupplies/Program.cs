using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SoftUniWaterSupplies
{
    class Program
    {
        static void Main()
        {
            decimal waterAvailable = decimal.Parse(Console.ReadLine());
            decimal[] bottles = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            long capacity = long.Parse(Console.ReadLine());
            decimal waterInBottles = bottles.Sum();
            decimal waterNeeded = capacity * bottles.Length - waterInBottles;
            Console.WriteLine();
            if (waterNeeded <= waterAvailable)
            {
                Console.WriteLine($"Enough water!");
                Console.WriteLine("Water left: {0}l.", waterAvailable - waterNeeded);
            }

            else
            {
                Console.WriteLine("We need more water!");
                int emptyBottles = 0;
                List<int> listOfindexes = new List<int>();
                if (waterAvailable % 2 == 0)
                {
                    for (int i = 0; i < bottles.Length; i++)
                    {
                        decimal neededForNextBottle = capacity - bottles[i];
                        waterAvailable -= neededForNextBottle;
                        if (waterAvailable < 0)
                        {
                            emptyBottles++;
                            listOfindexes.Add(i);
                        }
                    }
                }
                else
                {
                    for (int i = bottles.Length - 1; i >= 0; i--)
                    {
                        decimal neededForNextBottle = capacity - bottles[i];
                        waterAvailable -= neededForNextBottle;
                        if (waterAvailable < 0)
                        {
                            emptyBottles++;
                            listOfindexes.Add(i);
                        }
                    }
                }
                Console.WriteLine("Bottles left: {0}", emptyBottles);
                Console.WriteLine("With indexes: {0}", string.Join(", ", listOfindexes));
                Console.WriteLine("We need {0} more liters!", -waterAvailable);
            }

        }
    }
}
