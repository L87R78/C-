namespace _05DecodeRadioFrequencies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DecodeRadioFrequencies
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().Split();
            var list = new List<string>();
            for (int i = 0; i < inputLine.Length; i++)
            {
                int count = i;
                foreach (var nums in inputLine[i].Split('.'))
                {
                    int num = int.Parse(nums);
                    char letter = (char)num;
                    string letterStr = letter.ToString();
                    if (letter != 0)
                    {
                            list.Insert(count, letterStr);
                            count++;
                    }
                   
                }
            }
            Console.WriteLine(string.Join("",list));
        }
    }
}
