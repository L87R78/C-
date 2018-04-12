namespace _09ArrayProcessing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ArrayProcessing
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var listNums = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                listNums.Add(num);
            }
            int resultNum = listNums.Max();
            Console.WriteLine(resultNum);
        }
    }
}
