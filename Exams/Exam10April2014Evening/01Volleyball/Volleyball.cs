namespace _01Volleyball
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Volleyball
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            double weekendsHometown = double.Parse(Console.ReadLine());

            double hometowsResult = 48 - weekendsHometown;
            double normalWeekends = hometowsResult * 3 / 4;
            double holidaysResult = holidays * 2 / 3;
            double sum = weekendsHometown + normalWeekends + holidaysResult;

            if (year == "leap")
            {
                double procent =  0.85 * sum;
                procent = sum - procent;
                double totalPlays = Math.Floor(sum + procent);
                Console.WriteLine(totalPlays);
                return;
            }
            else
            {
                double totalPlays = Math.Floor(sum);
                Console.WriteLine(totalPlays);
            }
        }
    }
}
