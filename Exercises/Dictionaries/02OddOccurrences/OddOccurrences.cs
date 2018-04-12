namespace _02OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OddOccurrences
    {
        public static void Main()
        {
            var words = Console.ReadLine().ToLower().Split().ToArray();

            var dic = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!dic.ContainsKey(words[i]))
                {
                    dic.Add(words[i], 0);
                    dic[words[i]] = 1;
                }
                else
                {
                    dic[words[i]] += 1;
                }
            }
 
            StringBuilder sb = new StringBuilder();

            foreach (var word in dic.Where(x => x.Value % 2 == 1))
            {
                sb.Append(word.Key + ", ");
            }
           
            Console.WriteLine(sb.ToString().Trim(',', ' '));
        }
    }
}
