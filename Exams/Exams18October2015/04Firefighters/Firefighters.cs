namespace _04Firefighters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Firefighters
    {
        public static void Main()
        {
            int fireFighters = int.Parse(Console.ReadLine());
            int kids = 0;
            int adult = 0;
            int senior = 0;

            while (true)
            {
                string inputLine = Console.ReadLine();
                int sum = 0;
                if (inputLine.Equals("rain"))
                {
                    break; 
                }
                //search kids
                for (int i = 0; i < inputLine.Length; i++)
                {
                    if (sum >= fireFighters)
                    {
                        break;
                    }
                    char letter = inputLine[i];
                    if (letter == 'K')
                    {
                        kids++;
                        sum += 1;
                        
                    }
                }
                //search adult
                for (int i = 0; i < inputLine.Length; i++)
                {
                    if (sum >= fireFighters)
                    {
                        break;
                    }
                    char letter = inputLine[i];
                    if (letter == 'A')
                    {
                        adult++;
                        sum += 1;
                        
                    }
                }
                //search senior
                for (int i = 0; i < inputLine.Length; i++)
                {
                    if (sum >= fireFighters)
                    {
                        break;
                    }
                    char letter = inputLine[i];
                    if (letter == 'S')
                    {
                        senior++;
                        sum += 1;
                        
                    }
                }
            }
            Console.WriteLine("Kids: {0}",kids);
            Console.WriteLine("Adults: {0}",adult);
            Console.WriteLine("Seniors: {0}",senior);
        }
    }
}
