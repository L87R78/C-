namespace _31SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SquareNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).OrderByDescending(x => x).ToList();
            foreach (var item in numbers)
            {
                var help = Math.Sqrt(item);
                if (help == (int)help)
                    Console.Write(item + " ");
            }
        }
    }
}
