using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var hornets = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int count = 0;
            int loopLenght = beehives.Count;
            for (int i = 0; i < loopLenght; i++)
            {
                if (count == loopLenght)
                {
                    break;
                }
                if (hornets.Count == 0)
                {
                    break;
                }
                if (beehives.Count == 0)
                {
                    break;
                }
                int sumPoverHornets = hornets.Sum();
                if (beehives[i] >= sumPoverHornets)
                {
                    int resultSum = beehives[i] - sumPoverHornets;
                    if (resultSum == 0)
                    {
                        beehives.RemoveAt(i);
                        hornets.RemoveAt(0);
                        i--;
                    }
                    else
                    {
                        hornets.RemoveAt(0);
                        beehives[i] = resultSum;

                    }


                }
                else if (sumPoverHornets > beehives[i])
                {
                    beehives.RemoveAt(i);
                    i--;
                }
                count++;
            }

            if (beehives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", beehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
