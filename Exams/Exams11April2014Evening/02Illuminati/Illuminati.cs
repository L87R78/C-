namespace _02Illuminati
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Illuminati
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToUpper();

            long sumLetters = 0;
            long lenghtLetters = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char kur = text[i];
                if (kur == 'A')
                {
                    sumLetters += 65;
                    lenghtLetters++;
                }
                else if (kur == 'E')
                {
                    sumLetters += 69;
                    lenghtLetters++;
                }
                else if (kur == 'I')
                {
                    sumLetters += 73;
                    lenghtLetters++;
                }
                else if (kur == 'O')
                {
                    sumLetters += 79;
                    lenghtLetters++;
                }
                else if (kur == 'U')
                {
                    sumLetters += 85;
                    lenghtLetters++;
                }
            }
            Console.WriteLine(lenghtLetters);
            Console.WriteLine(sumLetters);
        }
    }
}
