namespace _01RabbitHole
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
            var commands = Console.ReadLine().Split().ToList();
            int energy = int.Parse(Console.ReadLine());

            int index = 0;
            while (energy > 0)
            {
              
                string[] wordsCommands = commands[index].Split('|');
                string currentCommand = wordsCommands[0];
                if (currentCommand == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    return;
                }
                int value = int.Parse(wordsCommands[1]);

                switch (currentCommand)
                {
                    case "Left":
                        index = Math.Abs(index - value) % commands.Count;
                        energy -= value;
                        break;
                    case "Right":
                        energy -= value;
                        index = (index + value) % commands.Count;
                        break;
                    case "Bomb":
                        commands.RemoveAt(index);
                        energy -= value;
                        index = 0;
                        if (energy <= 0)
                        {
                            Console.WriteLine("You are dead due to bomb explosion!");
                            return;
                        }
                    break;
                    default:
                        break;
                }
                if (commands[commands.Count - 1] == "RabbitHole")
                {
                    commands.Add("Bomb|" + energy);
                }
                else
                {
                    commands.RemoveAt(commands.Count - 1);
                    commands.Add("Bomb|" + energy);
                }
            }
            Console.WriteLine("You are tired. You can't continue the mission.");
        }
    }
}
