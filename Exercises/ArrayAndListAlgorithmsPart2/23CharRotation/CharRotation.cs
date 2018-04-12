namespace _23CharRotation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CharRotation
    {
        public static void Main()
        {
            char[] inputText = Console.ReadLine().ToCharArray();
            var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            StringBuilder sb = new StringBuilder();
           
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                int result = 0;
                if (inputNumbers[i] % 2 == 0)
                {
                    result = (inputText[i] - inputNumbers[i]);
                }
                else
                {
                    result = (inputText[i] + inputNumbers[i]);
                }
                var letter = Convert.ToChar(result);
                string resultLetter = letter.ToString();
                sb.Append(resultLetter);
            }

            Console.WriteLine(string.Join("",sb));
        }
    }
}
