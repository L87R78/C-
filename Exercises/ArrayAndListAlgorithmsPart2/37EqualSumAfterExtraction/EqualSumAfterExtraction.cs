namespace _37EqualSumAfterExtraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EqualSumAfterExtraction
    {
        public static void Main()
        {
            var firstNumbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            var secondNumbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int first = 0; first < firstNumbers.Count; first++)
            {
                for (int second = 0; second < secondNumbers.Count; second++)
                {
                    if (firstNumbers[first] == secondNumbers[second])
                    {
                        secondNumbers.RemoveAt(second);
                    }
                }
            }
            double sumFirst = firstNumbers.Sum();
            double sumSecond = secondNumbers.Sum();

            if (sumFirst > sumSecond)
            {
                Console.WriteLine($"No. Diff: {sumFirst - sumSecond}");
            }
            else if (sumFirst < sumSecond)
            {
                Console.WriteLine($"No. Diff: {sumSecond - sumFirst}");
            }
            else
            {
                Console.WriteLine($"Yes. Sum: {sumSecond}");
            }
        }
    }
}
