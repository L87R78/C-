namespace _03LetterRepetition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LetterRepetition
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            var dic = new Dictionary<string, int>();

            for (int i = 0; i < text.Length; i++)
            {
               char letter = text[i];
                string strLetter = letter.ToString();

                if (!dic.ContainsKey(strLetter))
                {
                    dic.Add(strLetter, 0);
                    dic[strLetter] = 1;
                }
                else
                {
                    dic[strLetter] += 1;
                }
            }

            foreach (var letter in dic)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
