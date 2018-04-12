using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Files
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dic = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine();
                var inputLineSplit = inputLine.Split(new char[] { ' ', '\\' }
                                            , StringSplitOptions
                                            .RemoveEmptyEntries);

                var root = inputLineSplit[0];
                var fileNameAndSizeSplit = inputLineSplit[inputLineSplit.Length - 1].Split(';');

                var fileName = fileNameAndSizeSplit[0];
                var fileSize = long.Parse(fileNameAndSizeSplit[1]);


                if (!dic.ContainsKey(root))
                {
                    dic.Add(root, new Dictionary<string, long>());
                    dic[root][fileName] = 0;
                    dic[root][fileName] = fileSize;

                }
                else
                {
                    if (!dic[root].ContainsKey(fileName))
                    {
                        dic[root][fileName] = fileSize;
                    }
                    else
                    {
                        dic[root][fileName] = fileSize;
                    }
                }
            }

            var endLine = Console.ReadLine().Split(new char[] { ' ' }
                                            , StringSplitOptions
                                            .RemoveEmptyEntries);
            var searchExtension = endLine[0];
            var searchRoot = endLine[2];

            if (dic.ContainsKey(searchRoot))
            {
                Dictionary<string, long> result = dic[searchRoot];

                foreach (var item in result.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
                {
                    if (item.Key.EndsWith(searchExtension))
                    {
                        Console.WriteLine($"{item.Key} - {item.Value} KB ");
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
