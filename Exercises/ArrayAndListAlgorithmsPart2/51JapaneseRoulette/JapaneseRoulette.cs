using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapaneseRoulette
{
    class JapaneseRoulette
    {
        static void Main()
        {
            var cylinder = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bullet = 0;

            for (int i = 0; i < cylinder.Count; i++)
            {
                if (cylinder[i] == 1)
                {
                    bullet = i;
                }
            }

            var playerInput = Console.ReadLine().Split();

            for (int i = 0; i < playerInput.Length; i++)
            {
                int fly = 0;
                var player = playerInput[i].Split(',');

                if (player[1] == "Right")
                {
                    int pover = int.Parse(player[0]);

                    InsertRight(cylinder, ref bullet, ref fly, ref pover);

                }
                else if (player[1] == "Left")
                {
                    int pover = int.Parse(player[0]);
                    fly = InsertLeft(cylinder, bullet, pover);
                }
                if (fly == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    return;
                }
                bullet = fly + 1;
            }
            Console.WriteLine("Everybody got lucky!");
        }

        private static void InsertRight(List<int> cylinder, ref int bullet, ref int fly, ref int pover)
        {
            for (int r = bullet + 1; r < cylinder.Count; r++)
            {
                if (r == cylinder.Count - 1)
                {
                    bullet = 0;
                    r = -1;
                }
                pover--;
                if (pover == 0)
                {
                    fly = Math.Abs(r);
                    break;
                }
            }

            //fly = (pover + bullet) % cylinder.Count;
        }

        private static int InsertLeft(List<int> cylinder, int bullet, int pover)
        {
            int fly;
            if (pover > 9)
            {
                fly = (cylinder.Count - ((pover - bullet) % cylinder.Count));
            }
            else
            {
                fly = Math.Abs(pover - bullet);
            }


            //for (int l = bullet + 1; l >= 0; l--)
            //{


            //    if (l - 1 == 0)
            //    {
            //        bullet = cylinder.Count;
            //        l = cylinder.Count;
            //    }
            //    pover--;
            //    if (pover == 0)
            //    {
            //        Console.WriteLine(l);
            //        return;
            //        fly = l;
            //    }

            //}
            return fly;
        }
    }
}
