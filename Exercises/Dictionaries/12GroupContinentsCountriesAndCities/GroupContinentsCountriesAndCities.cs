namespace _12GroupContinentsCountriesAndCities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class GroupContinentsCountriesAndCities
    {
        public static void Main()
        {
            var dic = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string continent = inputLine[0];
                string country = inputLine[1];
                string city = inputLine[2];

                if (!dic.ContainsKey(continent))
                {
                    dic.Add(continent, new Dictionary<string, List<string>>());
                    dic[continent][country] = new List<string>();
                    dic[continent][country].Add(city);
                }
                else
                {
                    if (!dic[continent].ContainsKey(country))
                    {
                        dic[continent][country] = new List<string>();
                        dic[continent][country].Add(city);
                    }
                    else
                    {
                        dic[continent][country].Add(city);
                    }
                }
            }
            Console.WriteLine();
            foreach (var continent in dic.Distinct().OrderBy(x => x.Key))
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value.Distinct().OrderBy(x => x.Key))
                {
                    string tempStr = "";
                    foreach (var city in country.Value.Distinct().OrderBy(x => x))
                    {
                        tempStr += city + ", ";
                    }
                    Console.WriteLine($"  {country.Key} -> {tempStr.Trim(',', ' ')}");
                }
            }
        }
    }
}
