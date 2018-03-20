namespace _02DetectiveBoev
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class DetectiveBoev
    {
        static void Main(string[] args)
        {
            string secretWord = Console.ReadLine();
            string message = Console.ReadLine();

            List<int> numbersSecretWord = new List<int>();
            
            for (int i = 0; i < secretWord.Length; i++)
            {
                int letter = secretWord[i];
                numbersSecretWord.Add(letter);
            }
            string resultSecretWord = numbersSecretWord.Sum().ToString();
            int finishSecretWord = 0;
            while (true)
            {
                finishSecretWord = 0;
                foreach (var digit in resultSecretWord)
                {
                    int num = digit - '0';
                    finishSecretWord += num;
                    
                }
                resultSecretWord = finishSecretWord.ToString();
                if (finishSecretWord < 9)
                {
                    break;  
                }
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < message.Length; i++)
            {
                double digit = message[i];
                double result = digit / finishSecretWord;
                string resultStr = result.ToString();
                if (resultStr.Length == 2 || resultStr.Length == 1)
                {
                    sb.Append((char)(digit + finishSecretWord));
                }
                else
                {
                    sb.Append((char)(digit - finishSecretWord));
                }
            }

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                Console.Write(sb[i]);
            }
            Console.WriteLine();     
        }
    }
}
