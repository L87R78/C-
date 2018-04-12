namespace _05MixedPhones
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MixedPhones
    {
        public static void Main()
        {
            var dic = new Dictionary<string, string>();

            while (true)
            {
                var inputLine = Console.ReadLine().Split();
                if (inputLine[0] == "Over")
                {
                    break;
                }
                string name = inputLine[0];
                string number = inputLine[2];

                bool IsSearchDigits = name.All(char.IsDigit);
                if (IsSearchDigits == false)
                {
                    if (!dic.ContainsKey(name))
                    {
                        dic.Add(name, null);
                        dic[name] = number;
                    }
                    else
                    {
                        dic[name] = number;
                    }
                }
                else
                {
                    if (!dic.ContainsKey(number))
                    {
                        dic.Add(number, null);
                        dic[number] = name;
                    }
                    else
                    {
                        dic[number] = name;
                    }
                }
            }
            foreach (var item in dic.OrderBy(x => x.Key))
            {
                string resultValue = item.Value;
                Console.WriteLine($"{item.Key} -> {resultValue}");
            }
        }
    }
}
