namespace _35FlipListSides
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class FlipListSides
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 1; i < numbers.Count / 2; i++)
            {
                int leftNum = numbers[i];
                numbers.RemoveAt(i);
                int rightNum = numbers[numbers.Count - 1 - i];
                numbers.RemoveAt(numbers.Count - 1 - i);
                numbers.Insert(i, rightNum);
                numbers.Insert(numbers.Count - i, leftNum);
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
