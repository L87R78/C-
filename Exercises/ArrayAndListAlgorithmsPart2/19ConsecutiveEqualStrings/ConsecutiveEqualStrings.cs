namespace _19ConsecutiveEqualStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ConsecutiveEqualStrings
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                                    .Split(new char[] { ' ' }
                                    ,StringSplitOptions
                                    .RemoveEmptyEntries)
                                    .ToList();

            int count = 1;
            for (int i = text.Count - 1; i > 0; i--)
            {
                
                if (text[i] == text[i - 1])
                {
                    count++;

                    if (count == 3)
                    {
                        Console.WriteLine($"{text[i]} {text[i]} {text[i]}");
                        break;
                    }
                }
                else
                {
                    count = 1;
                }
            }
        }
    }
}
