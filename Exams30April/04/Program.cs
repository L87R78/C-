using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split(new char[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            var list2 = list;
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                count++;
                if (list[i] != 0)
                {
                    int n = list[i];
                    list.RemoveAt(i);
                    list.Insert(i, 0);
                    i = n;
                }

            }
            Console.WriteLine(count);
        }
    }
}
