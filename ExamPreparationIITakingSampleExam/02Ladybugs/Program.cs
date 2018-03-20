using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var arrBugs = Console.ReadLine().Split().Select(int.Parse).ToList();

            var newArrBugs = new List<int>();
            for (int i = 0; i < size; i++)
            {
                newArrBugs.Add(0);
            }

            for (int a = 0; a < size; a++)
            {
                for (int b = 0; b < arrBugs.Count; b++)
                {
                    if (a == arrBugs[b])
                    {
                        newArrBugs.RemoveAt(a);
                        newArrBugs.Insert(a, 1);
                        break;
                    }

                }
            }

            while (true)
            {
                var commandLine = Console.ReadLine().Split();
                if (commandLine[0] == "end")
                {
                    break;
                }

                int indexBugs = int.Parse(commandLine[0]);
                string command = commandLine[1];
                int flylenght = int.Parse(commandLine[2]);

                if (indexBugs < 0 || indexBugs >= size)
                {
                    continue;
                }

                if (newArrBugs[indexBugs] == 0)
                {
                    continue;
                }
                newArrBugs[indexBugs] = 0;
                var position = indexBugs;
                while (true)
                {
                    if (command == "right")
                    {
                        position += flylenght;
                    }
                    else
                    {
                        position -= flylenght;
                    }

                    if (position < 0 || position >= size)
                    {
                        break;
                    }

                    if (newArrBugs[position] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        newArrBugs[position] = 1;
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", newArrBugs));
        }
    }
}
