namespace _30SortNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SortNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers.Sort();

            Console.WriteLine(string.Join(" <= ",numbers));
        }
    }
}
