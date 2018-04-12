namespace _47SortArrayUsingInsertionSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SortArrayUsingInsertionSort
    {
        public static void Main()
        {
            var numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbersList.Sort();
            Console.WriteLine(string.Join(" ", numbersList));
        }
    }
}
