namespace _04MagicStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MagicStrings
    {
        public static void Main(string[] args)
        {
            int diff = int.Parse(Console.ReadLine());
            string[] letters = {"s", "n", "k", "p"};
            int[] numbers = {3, 4, 1, 5 };
            List<string> resultList = new List<string>();
            for (int a1 = 0; a1 < 4; a1++)
            {
                for (int a2 = 0; a2 < 4; a2++)
                {
                    for (int a3 = 0; a3 < 4; a3++)
                    {
                        for (int a4 = 0; a4 < 4; a4++)
                        {
                            for (int a5 = 0; a5 < 4; a5++)
                            {
                                for (int a6 = 0; a6 < 4; a6++)
                                {
                                    for (int a7 = 0; a7 < 4; a7++)
                                    {
                                        for (int a8 = 0; a8 < 4; a8++)
                                        {
                                            int leftSum = numbers[a1] + numbers[a2] + numbers[a3] + numbers[a4];
                                            int rightSum = numbers[a5] + numbers[a6] + numbers[a7] + numbers[a8];
                                            if (Math.Abs(leftSum - rightSum) == diff)
                                            {
                                                string sequence =
                                                    letters[a8] +
                                                    letters[a7] +
                                                    letters[a6] +
                                                    letters[a5] +
                                                    letters[a4] +
                                                    letters[a3] +
                                                    letters[a2] +
                                                    letters[a1];
                                                resultList.Add(sequence);                                       
                                            }
                                        } 
                                    }
                                }
                            }
                        }
                    }
                }
            }
            resultList.Sort();
            if (resultList.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }
            foreach (var word in resultList)
            {
                Console.WriteLine(word);
            }
        }
    }
}
