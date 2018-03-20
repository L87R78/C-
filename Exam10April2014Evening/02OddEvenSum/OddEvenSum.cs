namespace _02OddEvenSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OddEvenSum
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;
            for (int i = 1; i <= n * 2; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 1)
                {
                    sumOdd += num;
                }
                else if (i % 2 == 0)
                {
                    sumEven += num;
                }
            }

            if (sumEven == sumOdd)
            {
                Console.WriteLine($"Yes, sum={sumOdd}");
            }
            else if (sumOdd > sumEven)
            {
                sumOdd = sumOdd - sumEven;
                Console.WriteLine($"No, diff={sumOdd}");
            }
            else if (sumOdd < sumEven)
            {
                sumEven = sumEven - sumOdd;
                Console.WriteLine($"No, diff={sumEven}");
            }
        }
    }
}
