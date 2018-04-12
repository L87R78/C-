namespace _16SocialMediaPosts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SocialMediaPosts
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, int>> social = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, List<string>>> comments = new Dictionary<string, Dictionary<string, List<string>>>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "drop the media") break;
                var comm = input.Split(' ');
                var command = comm[0];
                var name = comm[1];
                if (command == "post")
                {
                    if (!social.ContainsKey(name))
                        social.Add(name, new Dictionary<string, int>());
                    social[name].Add("Likes:", 0);
                    social[name].Add("Dislikes:", 0);
                }
                else if (command == "like")
                {
                    social[name]["Likes:"]++;
                }
                else if (command == "dislike")
                {
                    social[name]["Dislikes:"]++;
                }
                else if (command == "comment")
                {
                    var commentator = comm[2];
                    if (!comments.ContainsKey(name))
                    {
                        comments.Add(name, new Dictionary<string, List<string>>());
                    }
                    comments[name].Add(commentator, new List<string>());
                    for (int i = 3; i < comm.Length; i++)
                    {
                        comments[name][commentator].Add(comm[i]);
                    }
                }
            }
            foreach (var item in social.Keys)
            {
                var likes = social[item];
                Console.Write("Post: {0} ", item);
                foreach (var like in likes)
                {
                    Console.Write("| {0} {1} ", like.Key, like.Value);
                }
                Console.WriteLine();
                Console.WriteLine("Comments:");
                if (comments.ContainsKey(item))
                {
                    var comentz = comments[item];
                    foreach (var ppl in comentz)
                    {
                        Console.WriteLine("*  {0}: {1}", ppl.Key, String.Join(" ", ppl.Value));
                    }
                }
                else
                {
                    Console.WriteLine("None");
                }
            }
        }
    }
}

