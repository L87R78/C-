namespace _26RemoveNegativesReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RemoveNegativesReverse
    {
        public static void Main()
        {
            var listNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < listNumbers.Count; i++)
            {
                if (listNumbers[i] < 0)
                {
                    listNumbers.RemoveAt(i);
                    i--;
                }
            }
            if (listNumbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                listNumbers.Reverse();
                Console.WriteLine(string.Join(" ", listNumbers));
            }
        }
    }
}
