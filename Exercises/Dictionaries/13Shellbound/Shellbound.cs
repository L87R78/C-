namespace _13Shellbound
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Shellbound
    {
        public static void Main()
        {
            var dic = new Dictionary<string, List<long>>();
            while (true)
            {
                var inputLine = Console.ReadLine().Split(new char[] { ' ' }
                                        , StringSplitOptions.RemoveEmptyEntries);

                string city = inputLine[0];
                if (city == "Aggregate")
                {
                    break;
                }
                int size = int.Parse(inputLine[1]);

                bool IsSearchSizeInDicValue = false;
                if (!dic.ContainsKey(city))
                {
                    dic.Add(city, new List<long>());
                    dic[city].Add(size);
                }
                else
                {
                    foreach (var value in dic.Values)
                   {
                        IsSearchSizeInDicValue = value.Any(x => x == size);

                        if (IsSearchSizeInDicValue == false)
                        {
                            dic[city].Add(size);
                        }
                    }
                }
            }
       
            foreach (var key in dic)
            {
                string temp = "";
                foreach (var value in key.Value)
                {
                    temp += value + ", ";
                }
                if (key.Value.Count > 1)
                {
                    long sumValue = key.Value.Sum();
                    sumValue -= (sumValue / key.Value.Count);

                    Console.WriteLine($"{key.Key} -> {temp.Trim(',', ' ')} ({sumValue})");
                }
                else if (key.Value.Count == 1)
                {
                    Console.WriteLine($"{key.Key} -> {temp.Trim(',', ' ')} ({key.Value})");
                }
            }
        }
    }
}
