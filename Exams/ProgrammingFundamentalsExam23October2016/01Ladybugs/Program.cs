using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var inputLineSize = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var listSize = new List<int>();

            for (int a = 0; a < size; a++)
            {
                listSize.Add(0);
            }

            bool test = false;
            for (int a = 0; a < listSize.Count; a++)
            {
                for (int b = 0; b < inputLineSize.Count; b++)
                {
                    if (a == inputLineSize[b])
                    {
                        listSize.RemoveAt(a);
                        listSize.Insert(a, 1);
                        test = true;
                    }
                }
            }

            if (test == false)
            {
                return;
            }

            while (true)
            {
                var inputLine = Console.ReadLine().Split();
                if (inputLine[0] == "end")
                {
                    break;
                }

                int indexBugs = int.Parse(inputLine[0]);

                string command = inputLine[1];

                int flyIndex = int.Parse(inputLine[2]);

                if (indexBugs < 0 || indexBugs >= listSize.Count)
                {
                    continue;
                }
                if (listSize[indexBugs] == 0)
                {
                    continue;
                }

                listSize[indexBugs] = 0;

                bool leftArrayOrfoundPlace = false;

                while (!leftArrayOrfoundPlace)
                {
                    switch (command)
                    {
                        case "left":
                            indexBugs -= flyIndex;
                            break;
                        case "right":
                            indexBugs += flyIndex;
                            break;
                    }


                    if (indexBugs < 0 || indexBugs >= listSize.Count)
                    {
                        leftArrayOrfoundPlace = true;
                        continue;
                    }
                    if (listSize[indexBugs] == 1)
                    {
                        continue;
                    }
                    if (listSize[indexBugs] == 0)
                    {
                        listSize[indexBugs] = 1;
                        leftArrayOrfoundPlace = true;
                        continue;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", listSize));
        }
    }
}
