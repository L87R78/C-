namespace _05MultiplyArrayDoubles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MultiplyArrayDoubles
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                                .Split()
                                .Select(double.Parse)
                                .ToList();
            var multiply = double.Parse(Console.ReadLine());

            var listResult = new List<double>();

            for (int i = 0; i < numbers.Count; i++)
            {
                listResult.Add(multiply * numbers[i]);
            }
            Console.WriteLine(string.Join(" ",listResult));
        }
    }
}
