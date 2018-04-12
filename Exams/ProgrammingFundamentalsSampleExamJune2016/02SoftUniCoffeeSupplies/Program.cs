using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02SoftUniCoffeeSupplies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] parameters = Console.ReadLine().Split();
            string firstDelimiter = parameters[0];
            string secondDelimiter = parameters[1];

            string firstInputLine = Console.ReadLine();

            Dictionary<string, string> dicPeronalCoffe = new Dictionary<string, string>();
            Dictionary<string, long> dicQuantityCoffe = new Dictionary<string, long>();
            Dictionary<string, long> dicPersonalDrinkCoffe = new Dictionary<string, long>();

            List<string> ListOutOf = new List<string>();
            Dictionary<string, long> dicCoffeLeft = new Dictionary<string, long>();
            Dictionary<string, string> dicFor = new Dictionary<string, string>();


            while (!firstInputLine.Equals("end of info"))
            {
                if (firstInputLine.Contains(firstDelimiter))
                {
                    int indexFirsDelimiter = firstInputLine.IndexOf(firstDelimiter);

                    string name = firstInputLine.Substring(0, indexFirsDelimiter);
                    string coffe = firstInputLine.Substring(indexFirsDelimiter + firstDelimiter.Length);

                    if (!dicPeronalCoffe.ContainsKey(name))
                    {
                        dicPeronalCoffe.Add(name, null);
                        dicPeronalCoffe[name] = coffe;
                    }

                }
                else if (firstInputLine.Contains(secondDelimiter))
                {
                    int indexFirsDelimiter = firstInputLine.IndexOf(secondDelimiter);
                    string coffe = firstInputLine.Substring(0, indexFirsDelimiter);
                    string quantity = firstInputLine.Substring(indexFirsDelimiter + secondDelimiter.Length);
                    long quantityParseLong = long.Parse(quantity);

                    if (!dicQuantityCoffe.ContainsKey(coffe))
                    {
                        dicQuantityCoffe.Add(coffe, 0);
                        dicQuantityCoffe[coffe] = quantityParseLong;
                    }
                    else
                    {
                        dicQuantityCoffe[coffe] += quantityParseLong;
                    }
                }
                firstInputLine = Console.ReadLine();
            }
            string secondInputLine = Console.ReadLine();
            while (!secondInputLine.Equals("end of week"))
            {
                string[] secondInputLineSplit = secondInputLine
                                    .Split(new char[] { ' ' }
                                    , StringSplitOptions
                                    .RemoveEmptyEntries);
                string nameDrink = secondInputLineSplit[0];
                long nameQuantityCoffe = long.Parse(secondInputLineSplit[1]);

                if (!dicPersonalDrinkCoffe.ContainsKey(nameDrink))
                {
                    dicPersonalDrinkCoffe.Add(nameDrink, 0);
                    dicPersonalDrinkCoffe[nameDrink] = nameQuantityCoffe;
                }
                else
                {
                    dicPersonalDrinkCoffe[nameDrink] += nameQuantityCoffe;
                }
                secondInputLine = Console.ReadLine();
            }
            foreach (var item in dicPersonalDrinkCoffe)
            {
                foreach (var name in dicPeronalCoffe)
                {

                    if (item.Key == name.Key)
                    {
                        foreach (var coffe in dicQuantityCoffe)
                        {
                            if (name.Value == coffe.Key)
                            {
                                if (!dicCoffeLeft.ContainsKey(coffe.Key))
                                {
                                    dicCoffeLeft.Add(coffe.Key, 0);
                                    dicCoffeLeft[coffe.Key] = coffe.Value - item.Value;
                                    bool IsIgnore = false;
                                    foreach (var ite in dicCoffeLeft.Where(x => x.Value <= 0))
                                    {
                                        IsIgnore = true;
                                        ListOutOf.Add(ite.Key);
                                        dicCoffeLeft.Remove(ite.Key);
                                        break;
                                    }

                                    if (!dicFor.ContainsKey(name.Key) && IsIgnore == false)
                                    {
                                        dicFor.Add(name.Key, null);
                                        dicFor[name.Key] = name.Value;
                                    }

                                }
                                else
                                {
                                    dicCoffeLeft[coffe.Key] -= item.Value;
                                    bool IsIgnore = false;
                                    foreach (var ite in dicCoffeLeft.Where(x => x.Value <= 0))
                                    {
                                        IsIgnore = true;
                                        ListOutOf.Add(ite.Key);
                                        dicCoffeLeft.Remove(ite.Key);
                                        break;
                                    }
                                    if (!dicFor.ContainsKey(name.Key) && IsIgnore == false)
                                    {
                                        dicFor.Add(name.Key, null);
                                        dicFor[name.Key] = name.Value;
                                    }

                                }


                            }
                        }
                    }
                }
            }

            foreach (var itemValue in dicPeronalCoffe)
            {
                int count = 0;
                foreach (var itemKey in dicQuantityCoffe.Keys.Where(x => x.Contains(itemValue.Value)))
                {
                    count++;
                }
                if (count == 0)
                {
                    ListOutOf.Add(itemValue.Value);
                }
            }

            var dicTest2 = dicCoffeLeft.Where(x => x.Value == 0).ToArray();
            foreach (var item in dicTest2)
            {
                ListOutOf.Add(item.Key); //test add remove item.key
            }

            foreach (var item in dicTest2)
            {
                dicCoffeLeft.Remove(item.Key);
            }

            foreach (var item in ListOutOf)
            {
                Console.WriteLine("Out of {0}", string.Join(", ", item));
            }

            Console.WriteLine("Coffee Left:");
            foreach (var item in dicCoffeLeft.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
            Console.WriteLine("For:");
            foreach (var item in dicFor.OrderByDescending(y => y.Key).OrderBy(x => x.Value))
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}
