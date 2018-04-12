namespace _24PowerPlants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PowerPlants
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                                        .Split(new char[] { ' ' }
                                        ,StringSplitOptions
                                        .RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToArray();

            var coppyNumbersArr = numbers.ToArray();
            int index = 0;
            int lenghtLoop = 0;
            int countDays = 1;
            int countSeason = 0;

            bool fullZeroNumbers = false;
            for (int a = 0; a < numbers.Length; a++)
            {

                if (coppyNumbersArr[lenghtLoop] == numbers[a])
                {
                    index = a;
                }

                for (int c = 0; c < numbers.Length; c++)
                {
                    if (c == index)
                    {

                    }
                    else
                    {
                        if (numbers[c] > 0)
                        {
                            numbers[c] -= 1;
                        }
                    }
                }
                lenghtLoop++;
                coppyNumbersArr = numbers.ToArray();
                fullZeroNumbers = numbers.All(x => x == 0);
                if (fullZeroNumbers == true)
                {
                    Console.WriteLine($"survived {countDays} days ({countSeason} seasons)");
                    return;
                }
                else
                {
                    countDays++;
                }


                if (lenghtLoop == numbers.Length)
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] > 0)
                        {
                            numbers[i] += 1;
                        }
                    }
                    countSeason++;
                    a = -1;
                    lenghtLoop = 0;
                    coppyNumbersArr = numbers.ToArray();
                }
            } 
        }
    }
}
