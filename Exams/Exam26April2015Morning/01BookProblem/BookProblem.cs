namespace _01BookProblem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class BookProblem
    {
        static void Main(string[] args)
        {
            long numberPagesBook = long.Parse(Console.ReadLine());
            long campingDaysMonth = long.Parse(Console.ReadLine());
            long StefanReadsPagesBook = long.Parse(Console.ReadLine());

            double normalDays = 30 - campingDaysMonth;
            double normalPages = StefanReadsPagesBook * normalDays;
            double resultPagesReads = (Math.Ceiling(numberPagesBook / normalPages));

            if (normalPages == 0)
            {
                Console.WriteLine("never");
                return;
            }
            double resultYear = Math.Floor(resultPagesReads / 12);
            double resultMonth = resultPagesReads % 12;
            Console.WriteLine($"{resultYear} years {resultMonth} months");
        }
    }
}
