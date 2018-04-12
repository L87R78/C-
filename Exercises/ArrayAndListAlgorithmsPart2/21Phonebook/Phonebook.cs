namespace _21Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Phonebook
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            var inputName = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var dic = new Dictionary<string, string>();
            while (true)
            {
                var name = Console.ReadLine();
                if (name.Equals("done"))
                {
                    break;
                }

                for (int i = 0; i < inputName.Length; i++)
                {
                    if (inputName[i] == name)
                    {
                        Console.WriteLine($"{name} -> {inputNumbers[i]}");
                    }
                }
            }

            //foreach (var item in dic)
            //{
            //    Console.WriteLine($"{item.Key} -> {item.Value}");
            //}
        }
    }
}
