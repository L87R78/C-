namespace _04ArrayHistogram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ArrayHistogram
    {
        public static void Main(string[] args)
        {
            var inputline = Console.ReadLine()
                           .Split()
                           .ToArray();

            var dic = new Dictionary<string, int>();

            for (int i = 0; i < inputline.Length; i++)
            {
                if (!dic.ContainsKey(inputline[i]))
                {
                    dic.Add(inputline[i], 0);
                    dic[inputline[i]] = 1;
                }
                else
                {
                    dic[inputline[i]] += 1;
                }
            }

            foreach (var item in dic.OrderByDescending(x => x.Value))
            {
                double procent = (item.Value * 100) / (double)inputline.Length;
                Console.WriteLine($"{item.Key} -> {item.Value} times ({procent:F2}%)");
            }
        }
    }
}
