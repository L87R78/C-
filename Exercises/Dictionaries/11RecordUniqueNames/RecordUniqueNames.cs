namespace _11RecordUniqueNames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RecordUniqueNames
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                list.Add(input);
            }
            var hash = new HashSet<string>(list);
            List<string> listResult = hash.ToList();
            Console.WriteLine(string.Join("\n",listResult));
        }
    }
}
