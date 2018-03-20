namespace _03KingOfThieves
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class KingOfThieves
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char name = Console.ReadLine()[0];

            int test = 1;
            int test2 = 3;
            int test3 = n;
            int test4 = n - 2;

            Console.WriteLine("{0}{1}{0}",
                                new string('-', n / 2),
                                new string(name, test));
            int a = n / 2 - 1;
            int c = n / 2 - 1;

            for (int t = 0; t < c; t++)
            {
                Console.WriteLine("{0}{1}{0}",
                                new string('-', a),
                                new string(name, test2));
                a--;
                test2 += 2;
            }
            Console.WriteLine("{0}",
                                new string(name, test3));

            int aa = 1;
            int bb = n - 2;
            int cc = n / 2 - 1;

            for (int j = 0; j < c; j++)
            {
                Console.WriteLine("{0}{1}{0}",
                                new string('-', aa),
                                new string(name, test4));
                aa++;
                test4 -= 2;
            }
            Console.WriteLine("{0}{1}{0}",
                                new string('-', n / 2),
                                new string(name, test));
        }
    }
}
