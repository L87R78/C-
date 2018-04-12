namespace _32CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class CountNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var dic = new Dictionary<int, int>();

            for (int a = 0; a < numbers.Count; a++)
            {
                bool openLoop = true;
                foreach (var key in dic)
                {
                    if (numbers[a] == key.Key)
                    {
                        openLoop = false;
                    }
                }
                if (openLoop == true)
                {
                    for (int b = a ; b < numbers.Count; b++)
                    {
                        if (b + 1 >= numbers.Count)
                        {
                            if (!dic.ContainsKey(numbers[a]))
                            {
                                dic.Add(numbers[a], 0);
                                dic[numbers[a]] += 1;
                            }
                            break;
                        }
                        
                        if (numbers[a] == numbers[b + 1])
                        {
                            if (!dic.ContainsKey(numbers[a]))
                            {
                                dic.Add(numbers[a], 1);
                                dic[numbers[a]] += 1;
                            }
                            else
                            {
                                dic[numbers[a]] += 1;
                            }
                        }
                    }
                }
            }
            foreach (var item in dic.OrderBy(x => x.Key))
            {
                 Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
