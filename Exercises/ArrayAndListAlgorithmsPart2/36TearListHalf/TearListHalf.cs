namespace _36TearListHalf
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TearListHalf
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().ToList();

            string temp = "";
            var rightList = new List<string>();

            for (int i = numbers.Count - 1 ; i >= numbers.Count / 2; i--)
            {
                temp += numbers[i];
            }
            //Console.WriteLine(temp);
            int count = 0;
            temp = string.Concat(temp.Reverse());
            string temp2 = "";
            foreach (var letter in temp)
            {
                count++;
                temp2 += letter;
                if (count % 2 == 0)
                {
                    for (int i = temp2.Length - 1; i >= 0; i--)
                    {
                        rightList.Add(temp2[i].ToString());
                    }
                    
                    temp2 = "";
                }
                
            }
            var resultList = new List<string>();

            int lenght = 0;
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                resultList.Add(rightList[lenght]);
                resultList.Add(numbers[i]);
                resultList.Add(rightList[lenght + 1]);
                lenght += 2;
            }
            Console.WriteLine(string.Join(" ",resultList));
        }
    }
}
