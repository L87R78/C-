namespace _03PlaidTowel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PlaidTowel
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char test = char.Parse(Console.ReadLine());
            char test2 = char.Parse(Console.ReadLine());

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                                    new string(test, n),
                                    test2,
                                    new string(test, n * 2 - 1));
                int a = n - 1;
                int b = n * 2 - 3;
                int c = 1;

                for (int j = 0; j < n - 1; j++)
                {
                    Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}",
                                    new string(test, a),
                                    test2,
                                    new string(test, c),
                                    new string(test, b));
                    a--;
                    c += 2;
                    b -= 2;
                }
                Console.WriteLine("{0}{1}{0}{1}{0}",
                                    test2,
                                    new string(test, n * 2 - 1));

                int aa = 1;
                int bb = n * 2 - 3;
                int cc = 1;

                for (int j = 0; j < n - 1; j++)
                {
                    Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}",
                                    new string(test, aa),
                                    test2,
                                    new string(test, bb),
                                    new string(test, cc));
                    aa++;
                    cc += 2;
                    bb -= 2;
                }
            }
            Console.WriteLine("{0}{1}{2}{1}{0}",
                                new string(test, n),
                                test2,
                                new string(test, n * 2 - 1));
        }
    }
}
