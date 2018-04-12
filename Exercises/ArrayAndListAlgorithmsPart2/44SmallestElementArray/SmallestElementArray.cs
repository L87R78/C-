namespace _44SmallestElementArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class SmallestElementArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int minMun = numbers.Min();
            Console.WriteLine(minMun);
        }
    }
}
