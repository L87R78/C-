namespace _33RemoveElementsOddPositions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RemoveElementsOddPositions
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split().ToList();
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < text.Count; i++)
            {
                string word = text[i];
                if (i % 2 == 1)
                {
                    sb.Append(word);
                }
            }
            Console.WriteLine(sb);
        }
    }
}
