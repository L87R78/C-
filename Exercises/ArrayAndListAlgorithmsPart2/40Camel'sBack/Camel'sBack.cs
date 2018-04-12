namespace _40Camel_sBack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            var numberes = Console.ReadLine().Split().ToList();
            int num = int.Parse(Console.ReadLine());

            int rounds = 0;

            for (int i = num; i < numberes.Count; i++)
            {
                numberes.RemoveAt(num - num);
                numberes.RemoveAt(numberes.Count - 1);
                rounds++;
            }
            if (rounds == 0)
            {
                Console.WriteLine("already stable: {0}",string.Join(" ",numberes));
                return;
            }
            Console.WriteLine($"{rounds} rounds");
            Console.WriteLine("remaining: {0}",string.Join(" ",numberes));
        }
    }
}
