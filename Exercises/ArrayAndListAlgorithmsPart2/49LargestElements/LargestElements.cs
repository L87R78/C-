namespace _49LargestElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LargestElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int saveNum = int.Parse(Console.ReadLine());

            numbers = numbers.OrderByDescending(x => x).Take(saveNum).ToList();
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
