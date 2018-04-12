namespace _04DictRef
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DictRef
    {
        public static void Main()
        {
            var dic = new Dictionary<string, string>();
            while (true)
            {
                var inputLine = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                if (inputLine[0].Equals("end"))
                {
                    break;
                }
                string fisrtName = inputLine[0];
                string secondName = inputLine[2];

                bool isSearchDigits = secondName.All(char.IsDigit);

              
                bool b1 = dic.Keys.Any(x => x == inputLine[2]);

                if (b1 == true)
                {

                    foreach (var key in dic)
                    {
                        if (inputLine[2] == key.Key)
                        {
                            if (!dic.ContainsKey(fisrtName))
                            {
                                dic.Add(fisrtName, null);
                                dic[fisrtName] = key.Value;
                                break;
                            }
                            else
                            {
                                dic[fisrtName] = key.Value;
                                break;
                            }
                        }
                    }
                    continue;
                }
                if (isSearchDigits == true)
                {
                    if (!dic.ContainsKey(fisrtName))
                    {
                        dic.Add(fisrtName, null);
                        dic[fisrtName] = secondName;
                    }
                    else
                    {
                        dic[fisrtName] = secondName;
                    }
                }
            }
    
            foreach (var key in dic)
            {
                Console.WriteLine($"{key.Key} === {key.Value}");
            }
        }
    }
}
