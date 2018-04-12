namespace _01TravellerBob
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class TravellerBob
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            long numberMonthsContracts = long.Parse(Console.ReadLine());
            long bobFamily = long.Parse(Console.ReadLine());

            double travels = 12 * numberMonthsContracts;
            double familyMonth = bobFamily * 4;
            double normalMonths = 12 * (12 - (numberMonthsContracts + bobFamily));
            double normalMonthsResult = normalMonths * 3 / 5;
            //Console.WriteLine(normalMonthsResult);
            if (year == "leap")
            {
                double leapYearSum = (travels + familyMonth + normalMonthsResult);
                double leapYear = leapYearSum  * 0.05;
                double finish =Math.Floor(leapYearSum + leapYear);
                Console.WriteLine(finish);
            }
            else
            {
                double leapYearSum = (travels + familyMonth + normalMonthsResult);
                double finish = Math.Floor(leapYearSum);
                Console.WriteLine(finish);
            }
        }
    }
}
