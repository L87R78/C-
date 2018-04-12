namespace _10CountNegativeElementsArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CountNegativeElementsArray
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var listResult = new List<int>();
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    listResult.Add(num);
                }
            }
            if (listResult.Count > 0)
            {
                Console.WriteLine(listResult.Count);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
