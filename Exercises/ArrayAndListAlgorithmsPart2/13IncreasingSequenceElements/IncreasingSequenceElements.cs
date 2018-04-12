namespace _13IncreasingSequenceElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class IncreasingSequenceElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i + 1 >= numbers.Length)
                {
                    if (numbers[i] > numbers[i - 1])
                    {
                        Console.WriteLine("Yes");
                        return;
                    }
                }
                if (numbers[i] < numbers[i + 1])
                {
                    
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }
        }
    }
}
