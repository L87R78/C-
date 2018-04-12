namespace _02AverageCharacterDelimiter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AverageCharacterDelimiter
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var list = new List<double>();
            double averageResult = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char let = input[i];
                if (let != ' ')
                {
                    list.Add(let);
                }
            }
            averageResult = (int)list.Average();
            char letter = (char)averageResult;
            String resultSymbol = letter.ToString().ToUpper();
            //Console.WriteLine(resultSymbol);
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    Console.Write(resultSymbol);
                }
                else
                {
                    Console.Write(input[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
