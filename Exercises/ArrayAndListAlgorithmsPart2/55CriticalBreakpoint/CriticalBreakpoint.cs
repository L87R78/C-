namespace _55CriticalBreakpoint
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;
    class Line
    {
        public long X1 { get; set; }
        public long Y1 { get; set; }
        public long X2 { get; set; }
        public long Y2 { get; set; }
        public long Ratio { get; set; }
    }
    public class CriticalBreakpoint
    {
        public static void Main()
        {
            List<Line> lines = new List<Line>();
            while (true)
            {
                string[] inputLine = Console.ReadLine().Split();
               
                if (inputLine[0].Equals("Break"))
                {
                    break;
                }

                int[] numbers = inputLine.Select(int.Parse).ToArray();
                Line line = new Line
                {
                    X1 = numbers[0],
                    Y1 = numbers[1],
                    X2 = numbers[2],
                    Y2 = numbers[3],
                    Ratio = Math.Abs((numbers[2] + numbers[3]) - (numbers[0] + numbers[1]))
                };
                lines.Add(line);
            }
            bool BreakPoint = true;
            long actualRatio = 0l;

            foreach (Line line in lines)
            {
                if (actualRatio == 0 && line.Ratio != 0)
                {
                    actualRatio = line.Ratio;
                }
                if ((line.Ratio != actualRatio) && (line.Ratio != 0))
                {
                    BreakPoint = false;
                    break;
                }
              
            }
            if (BreakPoint)
            {
                BigInteger totalRatio = BigInteger.Pow(actualRatio, lines.Count);
                BigInteger criticalBreakPoint = 0;
                BigInteger.DivRem(totalRatio, lines.Count, out criticalBreakPoint);
                foreach (var line in lines)
                {
                    Console.WriteLine($"Line: [{line.X1}, {line.Y1}, {line.X2}, {line.Y2}]");
                }
                Console.WriteLine($"Critical Breakpoint: {criticalBreakPoint}");
            }
            else
            {
                Console.WriteLine("Critical breakpoint does not exist.");
            }
        }
    }
}
