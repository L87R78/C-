namespace _02SumOfElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SumOfElements
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split(new char[] { ' ' }
                                , StringSplitOptions
                                .RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();

            long maxNum = numbers.Max();
            long sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            long result = Math.Abs(sum - (maxNum * 2));
            if (result == 0)
            {
                Console.WriteLine($"Yes, sum={maxNum}");
            }
            else
            {
                Console.WriteLine($"No, diff={result}");
            }
        }
    }
}

