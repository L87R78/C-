namespace _04SumArrayElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SumArrayElements
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var listSumResult = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                listSumResult.Add(num);
            }
            long finishSum = listSumResult.Sum();
            Console.WriteLine(finishSum);
        }
    }
}
