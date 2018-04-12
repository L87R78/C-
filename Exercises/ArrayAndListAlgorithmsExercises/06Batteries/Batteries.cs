namespace _06Batteries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Batteries
    {
        public static void Main()
        {
            var capacityBattery = Console.ReadLine()
                                        .Split()
                                        .Select(double.Parse)
                                        .ToArray();

            var consumBattery = Console.ReadLine()
                                        .Split()
                                        .Select(double.Parse)
                                        .ToArray();

            double hours = double.Parse(Console.ReadLine());
            int countbaterry = 1;
            for (int a = 0; a < capacityBattery.Length; a++)
            {
                for (int b = a; b < consumBattery.Length; b++)
                {
                    double sum = hours * consumBattery[b];
                    double residue = capacityBattery[a] - sum;

                    if (sum < capacityBattery[a])
                    {
                        var resultProcent = (residue * 100) / capacityBattery[a];
                        Console.WriteLine($"Battery {countbaterry}: {residue:F2} mAh ({resultProcent:F2})%");
                        break;
                    }
                }
                countbaterry++;
            }
        }
    }
}
