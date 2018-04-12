namespace _17Altitude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Altitude
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();
            var airplaneAltitude = long.Parse(input[0]);

            for (int i = 1; i < input.Length; i+=2)
            {
                string command = input[i];

                if (command == "down")
                {
                    long numDown = long.Parse(input[i + 1]);
                    airplaneAltitude -= numDown;
                }
                else if (command == "up")
                {
                    long numUp = long.Parse(input[i + 1]);
                    airplaneAltitude += numUp;
                }
                if (airplaneAltitude <= 0)
                {
                    Console.WriteLine("crashed");
                    return;
                }
            }
            Console.WriteLine($"got through safely. current altitude: {airplaneAltitude}m");
        }
    }
}
