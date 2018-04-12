namespace _03SortArrayOfStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SortArrayOfStrings
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().Split();

            for (int a = 0; a < inputLine.Length; a++)
            {
                for (int b = a + 1; b < inputLine.Length; b++)
                {
                    int compare = string.Compare(inputLine[a], inputLine[b]);
                    if (compare == 1)
                    {
                        var temp = inputLine[b];
                        inputLine[b] = inputLine[a];
                        inputLine[a] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", inputLine));
        }
    }
}
