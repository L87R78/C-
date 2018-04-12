namespace _03NewHouse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class NewHouse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int tire = n / 2;
            int zvezda = 1;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                                    new string('-', tire),
                                    new string('*', zvezda));
                tire--;
                zvezda += 2;

            }
            Console.WriteLine(new string('*', n));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("|{0}|",
                                new string('*', n - 2));
            }
        }
    }
}
