namespace _43Winecraft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Winecraft
    {
        static void Main()
        {
            var grapes = Console.ReadLine().Split().Select(int.Parse).ToList();
            int day = int.Parse(Console.ReadLine());

            while (grapes.Count > day)
            {
                for (int n = 0; n < day; n++)
                {
                    for (int i = 0; i < grapes.Count; i++)
                    {
                        if (grapes[i] != 0)
                        {
                            grapes[i] += 1;
                        }
                        
                    }

                    for (int i = 0; i < grapes.Count; i++)
                    {
                        var isLeftIndex = i == 0;
                        var isRightIndex = i == grapes.Count - 1;

                        if (!isLeftIndex && !isRightIndex)
                        {
                            var previousIndex = i - 1;
                            var nextIndex = i + 1;

                            var iSGreaterThanPrevious = grapes[i] > grapes[previousIndex];
                            var isGreaterThanNext = grapes[i] > grapes[nextIndex];
                            var isGreaterGrape = iSGreaterThanPrevious && isGreaterThanNext;
                            if (isGreaterGrape)
                            {
                                grapes[i]--;

                                if (grapes[previousIndex] > 0)
                                {
                                    grapes[i]++;
                                    grapes[previousIndex] = Math.Max(grapes[previousIndex] - 2, 0);
                                }
                                if (grapes[nextIndex] > 0)
                                {
                                    grapes[i]++;
                                    grapes[nextIndex] = Math.Max(grapes[nextIndex] - 2, 0);
                                }
                            }
                        }
                    }


                    for (int i = 0; i < grapes.Count; i++)
                    {
                        if (grapes[i] <= day)
                        {
                            grapes.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ",grapes));
        }
    }
}
