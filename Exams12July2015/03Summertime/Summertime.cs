namespace _03Summertime
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Summertime
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}",
                            new string(' ', n / 2),
                            new string('*', n + 1));
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}",
                            new string(' ', n / 2),
                            new string('*', 1),
                            new string(' ', (n + 1) - 2));
            }

            int test = n - 1;
            int test2 = n / 2;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*",
                            new string(' ', test2),
                            new string(' ', test));
                test2--;
                test += 2;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("*{0}*",
                            new string('.', n * 2 - 2));
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("*{0}*",
                            new string('@', n * 2 - 2));
            }
            Console.WriteLine("{0}",
                            new string('*', n * 2));
        }
    }
}
