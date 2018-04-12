namespace _01ShootListElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ShootListElements
    {
        public static void Main()
        {
            var list = new List<int>();
            double average = 0;
            double lastElement = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command.Equals("stop"))
                {             
                    if (list.Count > 0)
                    {
                        Console.WriteLine("survivors: {0}",string.Join(" ",list));
                        return;
                    }
                    else
                    {
                        Console.WriteLine("you shot them all. last one was {0}",lastElement);
                        return;
                    }
                }
                else if (command.Equals("bang"))
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastElement}");
                        return;
                    }
                    average = list.Average();

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] <= average)
                        {
                            Console.WriteLine("shot {0}",list[i]);
                            lastElement = list[i];
                            list.RemoveAt(i);
                            break;
                        }
                    }
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i] -= 1;
                    }
                }
                else 
                {
                    list.Insert(0, int.Parse(command));
                }
            }
        }
    }
}
