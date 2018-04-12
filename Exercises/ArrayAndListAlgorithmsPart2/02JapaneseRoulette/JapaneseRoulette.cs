using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapaneseRoulette
{
    public class JapaneseRoulette
    {
        public static void Main()
        {
            var cylinder = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = 0;
            int barrel = 0;
            for (int i = 0; i < cylinder.Length; i++)
            {
                if (cylinder[i] == 1)
                {
                    index = i;
                    barrel = i;
                }
            }
            string[] commandLine = Console.ReadLine().Split();

            for (int i = 0; i < commandLine.Length; i++)
            {

                string[] line = commandLine[i].Split(',');
                int pover = int.Parse(line[0]);
                string direction = line[1];

                if (direction == "Left")
                {
                    while (pover > 0)
                    {
                        //pover--;
                        //barrel--;
                        //if (barrel == 0)                 завъртане от ляво на дасно
                        //{
                        //    barrel = cylinder.Length;
                        //}
                        barrel--;
                        pover--;
                        if (barrel < 0)
                        {
                            barrel = cylinder.Length - 1;
                        }
                    }
                }
                else if (direction == "Right")
                {

                    while (pover > 0)
                    {
                        pover--;
                        barrel++;
                        if (barrel > cylinder.Length - 1)
                        {
                            barrel = 0;
                        }   
                    }
                    
                }
                if (barrel == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    return;
                }
                barrel++;

                if (barrel > cylinder.Length - 1)
                {
                    barrel = 0;
                }
                else if (barrel > cylinder.Length - 1)
                {
                    barrel = 0;
                }
            }
            Console.WriteLine("Everybody got lucky!");
        }
    }
}
