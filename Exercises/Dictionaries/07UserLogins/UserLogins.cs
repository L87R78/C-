namespace _07UserLogins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UserLogins
    {
        public static void Main()
        {
            var dicLoginAndPassoword = new Dictionary<string, string>();
            while (true)
            {
                var inputLine = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                if (inputLine[0].Equals("login"))
                {
                    break;
                }
                string name = inputLine[0];
                string password = inputLine[2];


                if (!dicLoginAndPassoword.ContainsKey(name))
                {
                    dicLoginAndPassoword.Add(name, null);
                    dicLoginAndPassoword[name] = password;
                }
                else
                {
                    dicLoginAndPassoword[name] = password;
                }
            }
            int countNoSuccess = 0;
            while (true)
            {
                var inputLine = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                if (inputLine[0].Equals("end"))
                {
                    break;
                }
                string name = inputLine[0];
                string password = inputLine[2];
                bool IsOpenLogen = false;
                foreach (var nameLog in dicLoginAndPassoword)
                {
                    IsOpenLogen = dicLoginAndPassoword.Keys.Any(x => x == name);
                    if (nameLog.Key == name)
                    {
                        if (nameLog.Value == password)
                        {
                            Console.WriteLine($"{name}: logged in successfully");
                        }
                        else
                        {
                            Console.WriteLine($"{name}: login failed");
                            countNoSuccess++;
                        }
                    }
                    if (IsOpenLogen == false)
                    {
                        Console.WriteLine($"{name}: login failed");
                        countNoSuccess++;
                        break;
                    }
                  
                }
            }
            Console.WriteLine($"unsuccessful login attempts: {countNoSuccess}");
        }
    }
}
