using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDate = Console.ReadLine();
            DateTime currentDate = DateTime.Parse(inputDate);
            int steepHome = int.Parse(Console.ReadLine()) % 86400;
            int sekSteep = int.Parse(Console.ReadLine()) % 86400;

            double sumMinSek = steepHome * sekSteep;
            currentDate = currentDate.AddSeconds(sumMinSek);
            string output = currentDate.TimeOfDay.ToString();
            string str = currentDate.Day.ToString();
            Console.WriteLine();
            Console.WriteLine($"Time Arrival: {output}");
        }
    }
}
