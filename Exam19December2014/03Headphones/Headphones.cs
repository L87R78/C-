using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
     public class Program
    {
        public static void Main(string[] args)
        {
            var dateLine = Console.ReadLine();

            var date = DateTime.ParseExact(
                       dateLine,
                       "d-M-yyyy",
                        CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfYear);
        }
    }
}