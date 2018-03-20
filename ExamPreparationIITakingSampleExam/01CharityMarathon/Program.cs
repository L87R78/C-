using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            long lenghtMarathonDays = long.Parse(Console.ReadLine());
            long numberRunners = long.Parse(Console.ReadLine());
            long averageNumberLapsRunner = long.Parse(Console.ReadLine());
            long lenghtTrack = long.Parse(Console.ReadLine());
            long capacityTrack = long.Parse(Console.ReadLine());

            double moneyKilometer = double.Parse(Console.ReadLine());


            capacityTrack = capacityTrack * lenghtMarathonDays;
            numberRunners = Math.Min(capacityTrack, numberRunners);

            long totalMeters = numberRunners * averageNumberLapsRunner * lenghtTrack;
            long totalKilometers = totalMeters / 1000;
            double resultMoneyMarathon = totalKilometers * moneyKilometer;
            Console.WriteLine($"Money raised: {resultMoneyMarathon:F2}");
        }
    }
}
