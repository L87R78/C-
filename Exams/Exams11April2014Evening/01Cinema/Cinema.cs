namespace _01Cinema
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Cinema
    {
        public static void Main()
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            double  sumResult = 0;
            if (projection == "Premiere")
            {
                sumResult = (rows * col) * 12;
            }
            else if (projection == "Normal")
            {
                sumResult = (rows * col) * 7.5;
            }
            else if (projection == "Discount")
            {
                sumResult = (rows * col) * 5;
            }
            Console.WriteLine("{0:F2} leva",sumResult);
        }
    }
}
