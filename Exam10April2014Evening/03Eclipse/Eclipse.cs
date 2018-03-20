namespace _03Eclipse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Eclipse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}",
                            new string(' ', 1),
                            new string('*', n * 2 - 2),
                            new string(' ', n - 1));

            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("*{0}*{1}*{0}*",
                                new string('/', n * 2 - 2),
                                new string(' ', n - 1));
            }

            Console.WriteLine("*{0}*{1}*{0}*",
                            new string('/', n * 2 - 2),
                            new string('-', n - 1));

            for (int p = 0; p < n / 2 - 1; p++)
            {
                Console.WriteLine("*{0}*{1}*{0}*",
                                new string('/', n * 2 - 2),
                                new string(' ', n - 1));
            }
            Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}",
                           new string(' ', 1),
                           new string('*', n * 2 - 2),
                           new string(' ', n - 1));
        }
    }
}
