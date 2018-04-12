namespace _28SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i + 1 >= numbers.Count)
                {
                    break;
                }
                if (numbers[i] == numbers[i + 1])
                {
                    double sum = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i);
                    numbers.RemoveAt(i);
                    numbers.Insert(i, sum);
                    i = -1;
              
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
