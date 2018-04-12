namespace _06RotateArrayStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RotateArrayStrings
    {
        public static void Main()
        {
            var listLeters = Console.ReadLine().Split().ToList();

            for (int i = 0; i < listLeters.Count - 1; i++)
            {
                string firstLetter = listLeters[0];
                listLeters.RemoveAt(0);
                listLeters.Add(firstLetter);
            }
            Console.WriteLine(string.Join(" ", listLeters));
        }
    }
}
