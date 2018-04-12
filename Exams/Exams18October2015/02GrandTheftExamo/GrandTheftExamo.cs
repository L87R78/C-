namespace _02GrandTheftExamo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GrandTheftExamo
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            long slappedResult = 0;
            long escapeResult = 0;
            long beers = 0;

            for (int i = 0; i < n; i++)
            {
                long thieves = long.Parse(Console.ReadLine());
                long beer = long.Parse(Console.ReadLine());

                if (thieves > 5)
                {
                    slappedResult += 5;
                    escapeResult += thieves - 5;
                    beers += beer;
                }
                else
                {
                    slappedResult += thieves;
                    beers += beer;
                }
            }
            Console.WriteLine("{0} thieves slapped.", slappedResult);
            Console.WriteLine("{0} thieves escaped.", escapeResult);
            Console.WriteLine("{0} packs, {1} bottles.", beers / 6, beers % 6);
        }
    }
}
