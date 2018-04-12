namespace _25ResizableArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ResizableArray
    {
        public static void Main()
        {
            var list = new List<int>();

            while (true)
            {
                string[] inputLine = Console.ReadLine().Split();

                if (inputLine[0].Equals("end"))
                {
                    break;
                }
                if (inputLine.Length == 2)
                {
                    string firstCommand = inputLine[0];
                    int secondCommand = int.Parse(inputLine[1]);

                    switch (firstCommand)
                    {
                        case "push":
                            list.Add(secondCommand);
                            break;
                        case "removeAt":
                            if (list.Count > 0)
                            {
                                list.RemoveAt(secondCommand);
                            }
                            break;
                    }
                }
                else
                {
                    string firstCommand = inputLine[0];

                    switch (firstCommand)
                    {
                        case "pop":
                            if (list.Count > 0)
                            {
                                list.RemoveAt(list.Count - 1);
                            }
                            break;
                        case "clear":
                            list = new List<int>();
                            break;
                    }
                }
            }
            if (list.Count == 0)
            {
                Console.WriteLine("empty array");
            }
            else
            {
                Console.WriteLine(string.Join(" ",list));
            } 
        }
    }
}
