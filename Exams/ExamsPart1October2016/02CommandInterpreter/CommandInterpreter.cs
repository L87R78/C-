namespace _02CommandInterpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CommandInterpreter
    {
        public static void Main()
        {
            List<string> numbers = Console.ReadLine()
                           .Split(new char[] { ' ' }
                           , StringSplitOptions.RemoveEmptyEntries)
                           .ToList();
            Console.WriteLine();
            if (numbers.Count > 50)
            {
                return;
            }
            string inputLine = Console.ReadLine();
            int countComand = 0;
            while (true)
            {
                countComand++;
                string[] inputSplit = inputLine.Split(new char[] { ' ' }
                                            , StringSplitOptions
                                            .RemoveEmptyEntries);
                string command = inputSplit[0];
                if (countComand > 20)
                {
                    break;
                }
                if (command.Equals("end"))
                {
                    break;
                }
                switch (command)
                {
                    case "reverse":
                        int fromReverse = int.Parse(inputSplit[2]);
                        int countReverse = int.Parse(inputSplit[4]);
                        //int checkReverse = numbers.Length - fromReverse;

                        if (fromReverse < 0 || fromReverse >= numbers.Count
                            || (fromReverse + countReverse) > numbers.Count || countReverse < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            List<string> resultReverse = numbers.Skip(fromReverse)
                                                      .Take(countReverse).Reverse().ToList();

                            numbers.RemoveRange(fromReverse, countReverse);
                            numbers.InsertRange(fromReverse, resultReverse);
                        }
                        break;
                    case "sort":
                        int fromSort = int.Parse(inputSplit[2]);
                        int countSort = int.Parse(inputSplit[4]);
                        int chechSort = numbers.Count - fromSort;
                        if (fromSort < 0 || (fromSort + countSort) > numbers.Count
                            || countSort < 0 || fromSort >= numbers.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            string[] resultReverse = numbers.Skip(fromSort)
                                                  .Take(countSort).OrderBy(x => x).ToArray();
                            numbers.RemoveRange(fromSort, countSort);
                            numbers.InsertRange(fromSort, resultReverse);
                        }
                        break;
                    case "rollLeft":
                        int numleft = int.Parse(inputSplit[1]);
                        if (numleft < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            for (int i = 0; i < numleft % numbers.Count; i++)
                            {
                                string element = numbers[0];
                                numbers.RemoveAt(0);
                                numbers.Add(element);
                            }
                        }
                        break;
                    case "rollRight":
                        int numRight = int.Parse(inputSplit[1]);
                        if (numRight < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            for (int i = 0; i < numRight % numbers.Count; i++)
                            {
                                string element = numbers[numbers.Count - 1];
                                numbers.RemoveAt(numbers.Count - 1);
                                numbers.Insert(0, element);
                            }
                        }
                        break;
                    default:
                        break;
                }
                inputLine = Console.ReadLine();
            }
            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }
    }
}
