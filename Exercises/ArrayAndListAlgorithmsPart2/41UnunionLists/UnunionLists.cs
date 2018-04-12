namespace _41UnunionLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class UnunionLists
    {
        static void Main()
        {
            var primalNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int lenghtLoop = int.Parse(Console.ReadLine());

            var tempList = primalNumbers.ToList();
            for (int i = 0; i < lenghtLoop; i++)
            {
                var command = Console.ReadLine().Split().Select(int.Parse).ToList();

                for (int a = 0; a < primalNumbers.Count; a++)
                {
                    for (int b = 0; b < command.Count; b++)
                    {
                        if (primalNumbers[a] == command[b])
                        {
                            var removeNum = command[b];
                            command.RemoveAt(b);
                            primalNumbers.RemoveAll(x => x == removeNum);

                            a = -1;
                            break;

                        }
                    }
                }

                int templenghtarr = command.Count;
                for (int temp = 0; temp < templenghtarr; temp++)
                {
                    primalNumbers.Add(command[temp]);
                }
            }
            primalNumbers.Sort();
            Console.WriteLine(string.Join(" ", primalNumbers));


            //var primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //var n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //    for (int i2 = 0; i2 < list.Count; i2++)
            //    {
            //        if (primalList.Contains(list[i2]))
            //        {
            //            primalList.RemoveAll(x => x == list[i2]);
            //        }
            //        else
            //        {
            //            primalList.Add(list[i2]);
            //        }
            //    }
            //}

            //primalList.Sort();
            //Console.WriteLine(string.Join(" ", primalList));

        }
    }
}
