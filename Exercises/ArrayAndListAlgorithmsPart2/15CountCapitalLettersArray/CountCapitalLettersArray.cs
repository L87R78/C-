namespace _15CountCapitalLettersArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CountCapitalLettersArray
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split().ToArray();

            var count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Length == 1)
                {
                    char letter = char.Parse(text[i]);
                    if (letter >= 'A' && letter <= 'Z')
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
