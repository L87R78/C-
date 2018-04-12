namespace _03HornetAssault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class HornetAssault
    {
        public static void Main()
        {
            var listBees = Console.ReadLine().
                                Split(new char[] { ' ' }
                                , StringSplitOptions
                                .RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();

            var listHornets = Console.ReadLine().
                               Split(new char[] { ' ' }
                               , StringSplitOptions
                               .RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToList();

            var resultBees = new List<int>();
            var saveBees = listBees.ConvertAll(s => (int)s);
            
            int sumHornets = listHornets.Sum();

            for (int i = 0; i < listBees.Count; i++)
            {
                if (listHornets.Count == 0)
                {
                    break;
                }
                if (listBees[i] >= sumHornets)
                {
                    var temp = listBees[i] - sumHornets;
                    if (temp != 0)
                    {
                        listHornets.RemoveAt(0);
                        resultBees.Add(temp);
                        saveBees.RemoveAt(0);
                    }
                    else
                    {
                        listHornets.RemoveAt(0);
                        saveBees.RemoveAt(0);
                    }

                    
                    if (listHornets.Count == 0)
                    {
                        break;
                    }

                    sumHornets = listHornets.Sum();
                }
                else if (listBees[i] < sumHornets)
                {
                    saveBees.RemoveAt(0);
                    //todo...?
                }
            }
            Console.WriteLine(  );
            if (resultBees.Any(e => e > 0))
            {
                for (int l = 0; l < resultBees.Count; l++)
                {
                    saveBees.Add(resultBees[l]);
                }

                for (int k = 0; k < resultBees.Count; k++)
                {
                    int element = saveBees[saveBees.Count - 1];
                    saveBees.RemoveAt(saveBees.Count - 1);
                    saveBees.Insert(0, element);
                }

                Console.WriteLine(string.Join(" ",saveBees));
            }
            else
            {
                Console.WriteLine(string.Join(" ", listHornets));
            }

        }
    }
}
