namespace _20ArrayElementsEqualTheirIndex
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ArrayElementsEqualTheirIndex
    {
        public static void Main()
        {
            var listNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var listResult = new List<int>();
            for (int i = 0; i < listNumbers.Count; i++)
            {
                if (i == listNumbers[i])
                {
                    listResult.Add(listNumbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ",listResult));
        }
    }
}
