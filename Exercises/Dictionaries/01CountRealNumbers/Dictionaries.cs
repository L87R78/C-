namespace _01CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Dictionaries
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var dic = new Dictionary<double,int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!dic.ContainsKey(numbers[i]))
                {
                    dic.Add(numbers[i], 0);
                    dic[numbers[i]] = 1;
                }
                else
                {
                    dic[numbers[i]] += 1;
                }
            }
            foreach (var digit in dic.OrderByDescending(v => v.Value).OrderBy(k => k.Key))
            {
                Console.WriteLine($"{digit.Key} -> {digit.Value}");
            }
        }
    }
}
