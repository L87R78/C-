namespace _02ChessboardGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ChessboardGame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string massage = Console.ReadLine();

            if (n < 1)
            {
                return;
            }
            int blackTeam = 0;
            int whiteTeam = 0;
            for (int i = 0; i < massage.Length; i++)
            {
                if (i >= n * n)
                {
                    break;
                }
                char letter = massage[i];
                if (letter >= 'a' && letter <= 'z'
                    || letter >= 'A' && letter <= 'Z'
                    || letter >= '0' && letter <= '9')
                {
                    if (i % 2 == 0)
                    {
                        if (letter >= 'A' && letter <= 'Z')
                        {
                            whiteTeam += letter;
                        }
                        else
                        {
                            blackTeam += letter;
                        }
                    }
                    else if (i % 2 == 1)
                    {
                        if (letter >= 'A' && letter <= 'Z')
                        {
                            blackTeam += letter;
                        }
                        else
                        {
                            whiteTeam += letter;
                        }
                    }
                }
            }
   
            if (blackTeam == whiteTeam)
            {
                Console.WriteLine("Equal result: {0}", blackTeam);
                return;
            }
            if (blackTeam > whiteTeam)
            {
                Console.WriteLine("The winner is: black team");
                Console.WriteLine(blackTeam - whiteTeam);
            }
            else
            {
                Console.WriteLine("The winner is: white team");
                Console.WriteLine(whiteTeam - blackTeam);
            }
        }
    }
}
