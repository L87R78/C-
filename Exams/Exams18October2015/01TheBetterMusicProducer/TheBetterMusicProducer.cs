namespace _01TheBetterMusicProducer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class TheBetterMusicProducer
    {
        static void Main()
        {
            decimal soldAlbumsEurope = decimal.Parse(Console.ReadLine());
            decimal priceAlbumsEuropeEuro = decimal.Parse(Console.ReadLine());

            decimal soldAlbumsNorthAmerica = decimal.Parse(Console.ReadLine());
            decimal priceAlbumsNorthAmericaDollars = decimal.Parse(Console.ReadLine());

            decimal soldAlbumsSouthAmerica = decimal.Parse(Console.ReadLine());
            decimal priceAlbumsSouthAmericaPesos = decimal.Parse(Console.ReadLine());

            decimal numConcertTour = decimal.Parse(Console.ReadLine());
            decimal profitSingleConcertEuro = decimal.Parse(Console.ReadLine());

            decimal resultEurope = soldAlbumsEurope * (priceAlbumsEuropeEuro * 1.94m);
            decimal resultNorthAmerica = soldAlbumsNorthAmerica * (priceAlbumsNorthAmericaDollars * 1.72m);
            decimal resultSouthAmerica = soldAlbumsSouthAmerica * (priceAlbumsSouthAmericaPesos / 332.74m);

            decimal allAlbums = resultEurope + resultNorthAmerica + resultSouthAmerica;

            decimal resultAllAlbums = allAlbums * 0.65m;
            resultAllAlbums = resultAllAlbums * 0.80m;

            decimal convertProfit = numConcertTour * (profitSingleConcertEuro * 1.94m);

            if (convertProfit > 100000)
            {
                decimal resultConvertProfit = convertProfit * 0.85m;
                //Console.WriteLine(resultConvertProfit);
                if (resultConvertProfit > resultAllAlbums)
                {
                    Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", resultConvertProfit);
                    return;
                }
                else
                {
                    Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", resultAllAlbums);
                    return;
                }
            }
            if (convertProfit < resultAllAlbums)
            {
                Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", resultAllAlbums);
            }
            else
            {
                Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", convertProfit);
            }
        }
    }
}
