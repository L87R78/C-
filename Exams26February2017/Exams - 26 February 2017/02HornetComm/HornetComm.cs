namespace _02HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HornetComm
    {
        public static void Main()
        {
            Dictionary<string, List<string>> Broadcasts = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> Messages = new Dictionary<string, List<string>>();
            while (true)
            {
                var inputLine = Console.ReadLine().Split();

                var firstText = inputLine[0];
                var secondText = inputLine[inputLine.Length - 1];
                if (inputLine[0].Equals("Hornet"))
                {
                    break;
                }

                bool isSearchDigits = false;   //broadcasts
                bool isSearchDigitAndLetters = false; //broadcasts

                bool isSearchDigitsM = true;     // message
                bool isSearchDigitAndLettersM = true; //message

                //проверка за цифри в първата
                foreach (var letter in firstText)
                {
                    char let = letter;
                    if (let >= 48 && let <= 57)
                    {
                        isSearchDigits = true;
                        break;
                    }
                    else
                    {
                        isSearchDigitsM = false;
                    }
                }
                foreach (var letter in secondText)
                {
                    char let = letter;
                    if (let >= 48 && let <= 57   ||
                        let >= 65 && let <= 90   ||
                        let >= 97 && let <= 122)
                    {

                    }
                    else
                    {
                        isSearchDigitAndLetters = true;
                        isSearchDigitAndLettersM = false;
                        break;
                    }
                }
                if (isSearchDigits == false && isSearchDigitAndLetters == false)
                {
                    if (!Broadcasts.ContainsKey(secondText))
                    {
                        Broadcasts.Add(secondText, new List<string>());
                        Broadcasts[secondText].Add(firstText);
                    }
                    else
                    {
                        Broadcasts[secondText].Add(firstText);
                    }
                }

                if (isSearchDigitsM == true && isSearchDigitAndLettersM == true)
                {
                    if (!Messages.ContainsKey(firstText))
                    {
                        Messages.Add(firstText, new List<string>());
                        Messages[firstText].Add(secondText);
                    }
                    else
                    {
                        Messages[firstText].Add(secondText);
                    }
                }
            }
            Console.WriteLine();
            //todo....
        }
    }
}
