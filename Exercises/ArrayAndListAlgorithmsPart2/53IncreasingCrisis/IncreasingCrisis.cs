namespace _53IncreasingCrisis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class IncreasingCrisis
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var list = new List<int>();
            int count = 0;
            for (int a = 0; a < n; a++)
            {
                var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
                var tempList = new List<int>();
                tempList.Add(0);


                if (numbers[0] > numbers[1])
                {
                    for (int i = list.Count - 1; i >= 0; i--)
                    {
                        if (list[i] <= numbers[0])
                        {
                            list.Insert(i + 1, numbers[0]);

                            for (int t = list.Count - 1; t >= 0; t--)
                            {

                                if (list[t] == numbers[0])
                                {
                                    list = list.Take(t + 1).ToList();
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }

                else
                {
                    for (int b = 0; b < numbers.Count; b++)
                    {
                        if (numbers[b] >= tempList[tempList.Count - 1])
                        {
                            tempList.Add(numbers[b]);
                            //5 4 1 6 7
                        }
                        else
                        {
                            break;
                        }
                    }
                    count++;
                    tempList.RemoveAt(0);

                    if (count > 1)
                    {
                        for (int i = list.Count - 1; i >= 0; i--)
                        {
                            if (list[i] <= tempList[0])
                            {
                                list.InsertRange(i + 1, tempList);
                                break;
                            }
                        }
                    }
                    else
                    {
                        list = tempList;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
