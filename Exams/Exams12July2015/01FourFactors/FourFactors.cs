namespace _01FourFactors
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class FourFactors
    {
        static void Main(string[] args)
        {
            double FG = double.Parse(Console.ReadLine());
            double FGAвкошаОпитите = double.Parse(Console.ReadLine());
            double Points = double.Parse(Console.ReadLine());
            double TOVГрешки = double.Parse(Console.ReadLine());

            double ORB = double.Parse(Console.ReadLine());
            double OppDRB = double.Parse(Console.ReadLine());
            double FT = double.Parse(Console.ReadLine());
            double FTA = double.Parse(Console.ReadLine());

            double eFG = (FG + 0.5 * Points) / FGAвкошаОпитите;
            double TOV = TOVГрешки / (FGAвкошаОпитите + 0.44 * FTA + TOVГрешки);
            double ORBB = ORB / (ORB + OppDRB);
            double FTT = FT / FGAвкошаОпитите;

            Console.WriteLine("eFG% {0:F3}", eFG);
            Console.WriteLine("TOV% {0:F3}", TOV);
            Console.WriteLine("ORB% {0:F3}", ORBB);
            Console.WriteLine("FT% {0:F3}", FTT);
        }
    }
}
