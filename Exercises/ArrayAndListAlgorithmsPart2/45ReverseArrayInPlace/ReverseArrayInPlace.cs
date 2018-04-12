namespace _45ReverseArrayInPlace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ReverseArrayInPlace
    {
        public static void Main()
        {
            var numbersList = Console.ReadLine().Split().ToList();

            numbersList.Reverse();
            Console.WriteLine(string.Join(" ",numbersList));
        }
    }
}
