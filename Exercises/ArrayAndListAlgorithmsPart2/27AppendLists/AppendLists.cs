namespace _27AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AppendLists
    {
        public static void Main()
        {
            var listNumbers = Console.ReadLine().Split('|');
                                   

            var listResult = new List<string>();
            for (int l = 0; l < listNumbers.Length; l++)
            {
                string temp = listNumbers[l].Trim();
                listResult.Add(temp);
            }

            listResult.Reverse();
            Console.WriteLine(string.Join(" ", listResult));
        }
    }
}
