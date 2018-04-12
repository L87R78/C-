namespace _54Extremums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();
            var listResult = new List<int>();

            if (command == "Max")
            {
                for (int a = 0; a < numbers.Count; a++)
                {
                    int count = 0;
                    int finishNum = 0;

                    int max = int.MinValue;

                    var charArr = numbers[a].ToCharArray().ToList();
                    while (count <= numbers[a].Length)
                    {
                        string strNum = "";
                        for (int i = 0; i < charArr.Count; i++)
                        {
                            strNum += charArr[i];
                        }
                        int num = int.Parse(strNum);

                        if (num > max)
                        {
                            max = num;
                            finishNum = num;
                        }
                        char element = charArr[0];
                        charArr.RemoveAt(0);
                        charArr.Add(element);
                        count++;
                    }
                    listResult.Add(finishNum);
                }
            }
            else
            {
                for (int a = 0; a < numbers.Count; a++)
                {
                    int count = 0;
                    int finishNum = 0;

                    int min = int.MaxValue;

                    var charArr = numbers[a].ToCharArray().ToList();
                    while (count <= numbers[a].Length)
                    {
                        string strNum = "";
                        for (int i = 0; i < charArr.Count; i++)
                        {
                            strNum += charArr[i];
                        }
                        int num = int.Parse(strNum);

                        if (num < min)
                        {
                            min = num;
                            finishNum = num;
                        }
                        char element = charArr[0];
                        charArr.RemoveAt(0);
                        charArr.Add(element);
                        count++;
                    }
                    listResult.Add(finishNum);
                }
            }
            long sumResult = listResult.Sum();
            Console.WriteLine(string.Join(", ", listResult));
            Console.WriteLine(sumResult);
        }
    }
}
