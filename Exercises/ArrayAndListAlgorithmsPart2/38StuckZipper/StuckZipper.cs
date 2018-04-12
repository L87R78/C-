namespace _38StuckZipper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StuckZipper
    {
        public static void Main()
        {
            var firstPart = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondPart = Console.ReadLine().Split().Select(int.Parse).ToList();
  
            var bothParts = firstPart.Select(el => el).Concat(secondPart);

            var min = Math.Abs(bothParts.Min());
            for (int i = 0; i < firstPart.Count; i++)
            {
                if (Math.Abs(firstPart[i]).ToString().Length > min.ToString().Length)
                {
                    firstPart.Remove(firstPart[i]);
                    i--; 
                }
            }
            for (int i = 0; i < secondPart.Count; i++)
            {
                if (Math.Abs(secondPart[i]).ToString().Length > min.ToString().Length)
                {
                    secondPart.Remove(secondPart[i]);
                    i--; 
                }
            }
            var maxLenght = Math.Max(firstPart.Count, secondPart.Count);
            var result = new List<int>();

            for (int i = 0; i < maxLenght; i++)
            {  
                if (i <= secondPart.Count - 1)
                {
                    result.Add(secondPart[i]);
                }

                if (i <= firstPart.Count - 1)
                {
                    result.Add(firstPart[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
