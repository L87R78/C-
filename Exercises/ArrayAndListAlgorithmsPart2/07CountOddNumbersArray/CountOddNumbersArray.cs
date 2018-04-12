namespace _07CountOddNumbersArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CountOddNumbersArray
    {
        public static void Main()
        {
            var listNumbers = Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToList();
            int count = 0;
            for (int i = 0; i < listNumbers.Count; i++)
            {
                int num = listNumbers[i];
                num = Math.Abs(num);
                if (num % 2 == 1)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
