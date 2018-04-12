namespace _15ForumTopics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ForumTopics
    {
        public static void Main()
        {
            var dic = new Dictionary<string, List<string>>();
            while (true)
            {
                var inputLine = Console.ReadLine().Split(new char[] { '-', '>' },StringSplitOptions.RemoveEmptyEntries);
                if (inputLine[0].Equals("filter"))
                {
                    break;
                }
                string topic = inputLine[0];
                var selcondInputLine = inputLine[1].Split(new char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries);

                if (!dic.ContainsKey(topic))
                {
                    dic.Add(topic, new List<string>());
                    dic[topic].AddRange(selcondInputLine);
                }
                else
                {
                    dic[topic].AddRange(selcondInputLine);
                }
            }

            var outputWord = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            bool IsFindsWord = false;
            int lenghtOutputWord = outputWord.Length;
            foreach (var key in dic)
            {
                int tempCount = 0;
                foreach (var outputword in outputWord)
                {
                    IsFindsWord = key.Value.Any(x => x == outputword);

                    if (IsFindsWord == true)
                    {
                        tempCount++;
                    }
                }

                if (tempCount == lenghtOutputWord)
                {
                    Console.WriteLine($"{key.Key}| #{string.Join(", #",key.Value.Distinct())}");
                }
            }
        }
    }
}
