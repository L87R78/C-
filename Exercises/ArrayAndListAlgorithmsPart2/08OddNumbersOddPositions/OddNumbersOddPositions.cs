namespace _08OddNumbersOddPositions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class OddNumbersOddPositions
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var listOdd = new List<int>();
            var listIndex = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int index = Math.Abs(numbers[i]);
                if (i % 2 == 1)
                {
                    if (index % 2 == 1)
                    {
                        listIndex.Add(i);
                        listOdd.Add(numbers[i]);

                    }
                }
            }
            if (listIndex.Count == 0)
            {
                return;
            }
            for (int i = 0; i < listIndex.Count; i++)
            {
                Console.WriteLine("Index {0} -> {1}",listIndex[i],listOdd[i]);
            }
        }
    }
}
