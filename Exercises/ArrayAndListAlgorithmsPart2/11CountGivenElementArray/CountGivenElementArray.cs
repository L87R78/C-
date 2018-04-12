namespace _11CountGivenElementArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CountGivenElementArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                            .Split(new char[] { ' ' }
                            ,StringSplitOptions
                            .RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            var element = int.Parse(Console.ReadLine());

            int[] arrResult = numbers.Where(x => x == element).ToArray();
            Console.WriteLine(arrResult.Length);
        }
    }
}
