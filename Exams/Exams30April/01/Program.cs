namespace _01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            long lenghtBugs = long.Parse(Console.ReadLine());
            decimal widhtBugs = decimal.Parse(Console.ReadLine());


            long lenghtResult = lenghtBugs * 100;
            decimal result = lenghtResult % widhtBugs;

       

            if (result == 0)
            {
                decimal finish = (lenghtBugs * widhtBugs) * 100;
             
                Console.WriteLine($"{finish:F2}");
            }
            else
            {
                decimal finish = (lenghtResult / widhtBugs) * 100;
                Console.WriteLine($"{finish:F2}%");
            }
        }
    }
}
