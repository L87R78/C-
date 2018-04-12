namespace _18BallisticsTraining
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BallisticsTraining
    {
        public static void Main()
        {
            var coordinatesPlane = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var commandInput = Console.ReadLine().Split().ToArray();

            double numX = 0;
            double numY = 0;

            for (int com = 0; com < commandInput.Length - 1; com+=2)
            {
                string command = commandInput[com];
               
                var number = double.Parse(commandInput[com + 1]);
                switch (command)
                {
                    case "right":
                        numX += number;
                        break;
                    case "left":
                        numX -= number;
                        break;
                    case "down":
                        numY -= number;
                        break;
                    case "up":
                        numY += number;
                        break;
                    default:
                        break;
                }

                if (numX == coordinatesPlane[0] && numY == coordinatesPlane[1])
                {
                    Console.WriteLine($"firing at [{numX}, {numY}]");
                    Console.WriteLine("got 'em!");
                    return;
                }
            }
            Console.WriteLine($"firing at [{numX}, {numY}]");
            Console.WriteLine("better luck next time...");
        }
    }
}
