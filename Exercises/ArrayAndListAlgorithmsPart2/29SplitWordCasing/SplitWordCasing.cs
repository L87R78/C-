namespace _29SplitWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SplitWordCasing
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }
                ,StringSplitOptions
                .RemoveEmptyEntries);

            var listUpper = new List<string>();
            var listLower = new List<string>();
            var listMix = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                bool IsResultLowerWord = false;
                bool IsResultUpperWord = false;

                string word = input[i];

                IsResultLowerWord = word.All(x => x >= 97 && x <= 122);
                IsResultUpperWord = word.All(x => x >= 65 && x <= 90);

                if (IsResultLowerWord == true)
                {
                    listLower.Add(word);
                }
                else if (IsResultUpperWord == true)
                {
                    listUpper.Add(word);
                }
                else
                {
                    listMix.Add(word);
                }
            }
            Console.WriteLine("Lower-case: {0}",string.Join(", ", listLower));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", listMix));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", listUpper));
        }
    }
}
