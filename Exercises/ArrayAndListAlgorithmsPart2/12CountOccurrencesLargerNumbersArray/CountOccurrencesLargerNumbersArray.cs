namespace _12CountOccurrencesLargerNumbersArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CountOccurrencesLargerNumbersArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                                    .Split()
                                    .Select(double.Parse)
                                    .ToArray();
            double element = double.Parse(Console.ReadLine());

            var count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > element)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
