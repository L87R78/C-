namespace _08FilterBase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FilterBase
    {
        public static void Main()
        {
            var Age = new Dictionary<string, int>();
            var Salary = new Dictionary<string, double>();
            var Position = new Dictionary<string, string>();
            while (true)
            {
                var inputLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (inputLine[0].Equals("filter"))
                {
                    break;
                }
                string name = inputLine[0];
                int secondInt = 0;
                double secondDouble = 0;
                bool resultInt = int.TryParse(inputLine[2], out secondInt);
                bool resultDouble = double.TryParse(inputLine[2], out secondDouble);
                if (resultInt == true)
                {
                    if (!Age.ContainsKey(name))
                    {
                        Age.Add(name, 0);
                        Age[name] = int.Parse(inputLine[2]);
                    }
                    else
                    {
                        Age[name] = int.Parse(inputLine[2]);
                    }
                }
                else if (resultDouble == true)
                {
                    if (!Salary.ContainsKey(name))
                    {
                        Salary.Add(name, 0);
                        Salary[name] = double.Parse(inputLine[2]);
                    }
                    else
                    {
                        Salary[name] = double.Parse(inputLine[2]);
                    }
                }
                else
                {
                    if (!Position.ContainsKey(name))
                    {
                        Position.Add(name, null);
                        Position[name] = inputLine[2];
                    }
                    else
                    {
                        Position[name] = inputLine[2];
                    }
                }
            }

            string output = Console.ReadLine();

            if (output == "Age")
            {
                foreach (var item in Age)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Age: {item.Value}");
                    Console.WriteLine("====================");
                }
            }
            else if (output == "Position")
            {
                foreach (var item in Position)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Position: {item.Value}");
                    Console.WriteLine("====================");
                }
            }
            else
            {
                foreach (var item in Salary)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Salary: {item.Value:F2}");
                    Console.WriteLine("====================");
                }
            }     
        }
    }
}
