namespace _39DistinctList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DistinctList
    {
        public static void Main()
        {
            var numberes = Console.ReadLine().Split().ToList();

            while (true)
            {
                string inputDigits = Console.ReadLine();
                if (inputDigits.Equals("end"))
                {
                    break;
                }

                string digits = inputDigits[0].ToString();

                for (int i = 0; i < numberes.Count; i++)
                {
                    if (int.Parse(digits) == i)
                    {
                        //numberes.RemoveAt(i);
                        numberes.Insert(i,inputDigits);
                        break;
                    }
                }
                
            }
            Console.WriteLine(string.Join(" ",numberes));
        }
    }
}
