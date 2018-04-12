namespace _52Ladybugs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Ladybugs
    {
        public static void Main()
        {
            int area = int.Parse(Console.ReadLine());
            var bugs = Console.ReadLine().Split().Select(int.Parse).ToList();


            int[] arrBugs = new int[area];
            List<int> listBugs = arrBugs.OfType<int>().ToList();


            for (int a = 0; a < area; a++)
            {
                for (int b = 0; b < bugs.Count; b++)
                {
                    if (bugs[b] == a)
                    {
                        listBugs[a] += 1;
                    }
                }
             
            }

            while (true)
            {
                var command = Console.ReadLine().Split();
                if (command[0].Equals("end"))
                {
                    break;
                }
                int index = int.Parse(command[0]);
                string fly = command[1];
                int jumpIndex = int.Parse(command[2]);
                if (index < 0 || index>= listBugs.Count)
                {
                    continue;
                }
                if (listBugs[index] == 0)
                {
                    continue;
                }

                if (fly == "left")
                {
                    int tempFly = 0;
                    if (listBugs[index] == 1 && jumpIndex >= -area && jumpIndex <= area)
                    {
                        tempFly = Math.Abs((index - jumpIndex) % listBugs.Count);
                        for (int i = listBugs.Count - 1; i >= 0; i--)
                        {
                            if (i == tempFly)
                            {
                                listBugs.RemoveAt(index);
                                listBugs.Insert(i, 1);
                                break;
                            }
                        }
                    }
                }
                else if (fly == "right")
                {
                    int tempFly = 0;
                    if (listBugs[index] == 1 && jumpIndex >= -area && jumpIndex <= area)
                    {
                        tempFly = (index + jumpIndex) % listBugs.Count;

                        for (int i = index; i < listBugs.Count; i++)
                        {
                            if (listBugs[i] != 1)
                            {
                                listBugs.Insert(i, 1);
                                listBugs.RemoveAt(listBugs.Count - 1);
                            }
                        }
                        listBugs.RemoveAt(index);
                        listBugs.Insert(index, 0);
                    }
                }
            }
            Console.WriteLine(string.Join(" ",listBugs));
        }
    }
}
