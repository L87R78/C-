namespace _50RabbitHole
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RabbitHole
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            int energy = int.Parse(Console.ReadLine());

            int index = 0;
            int flyIndex = 0;
            while (energy >= 0)
            {
                string[] command = inputLine[index].Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    return;
                }
                else if (command[0] == "Left")
                {
                    int num = int.Parse(command[1]);
                    if (num > 0)
                    {
                        flyIndex = Math.Abs((index - num) % inputLine.Count);
                        energy -= num;
                        index = flyIndex;
                    }

                }
                else if (command[0] == "Right")
                {
                    int num = int.Parse(command[1]);
                    if (num > 0)
                    {

                        flyIndex = (index + num) % inputLine.Count;
                        energy -= num;
                        index = flyIndex;
                    }

                }
                else if (command[0] == "Bomb")
                {
                    int num = int.Parse(command[1]);
                    energy -= num;
                    if (energy <= 0)
                    {
                        Console.WriteLine("You are dead due to bomb explosion!");
                        return;
                    }
                    inputLine.RemoveAt(index);
                    index = 0;
                }

                if (inputLine[inputLine.Count - 1] != "RabbitHole")
                {
                    inputLine.RemoveAt(inputLine.Count - 1);
                }
                inputLine.Add("Bomb|" + energy);

            }
            Console.WriteLine("You are tired. You can't continue the mission.");











            //ако искаме в масив 2 3 4 5 6 7 2 3 и цифрата 4 да отиде 11
            //позиции на дясно и да се вмъкне = 2 3 4 5 6 4 7 2 3

            //решение
            //var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            //int fly = 0;
            //for (int i = 0; i < numbers.Count; i++)
            //{

            //    if (numbers[i] == 4)
            //    {
            //        int n = int.Parse(Console.ReadLine());

            //        fly = (n + i) % numbers.Count;
            //        numbers.Insert(fly, 4);
            //    }
            //}


















            //ако искаме в масив 2 3 4 5 6 7 2 3 и цифрата 4 да отиде 8
            //позиции на ляво(но следкато стигне 0-индекс да започне да върти на дясно) и да 
            //се вмъкне = 2 3 4 5 6 7 4 2 3

            //решение
            //var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            //int fly = 0;
            //for (int i = 0; i < numbers.Count; i++)
            //{

            //    if (numbers[i] == 4)
            //    {
            //        int n = int.Parse(Console.ReadLine());

            //        fly = Math.Abs(n - i) % numbers.Count;
            //        numbers.Insert(fly, 4);
            //    }
            //}











            //ако искаме в масив 2 3 4 5 6 7 2 3 и цифрата 4 да отиде 5
            //позиции на ляво(но следкато стигне 0-индекс да започне да върти на дясно) и да 
            //се вмъкне = 2 3 4 5 6 4 7 2 3

            //решение
            //var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            //int fly = 0;
            //for (int i = 0; i < numbers.Count; i++)
            //{

            //    if (numbers[i] == 4)
            //    {
            //        int n = int.Parse(Console.ReadLine());

            //        fly = numbers.Count - ((n - i) % numbers.Count);

            //        numbers.Insert(fly, 4);
            //    }
            //}
        }
    }
}
