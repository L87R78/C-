namespace _48InsertionSortUsingList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class InsertionSortUsingList
    {
        public static void Main()
        {
            var numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbersList.Sort();
            Console.WriteLine(string.Join(" ", numbersList));
        }
    }
}
