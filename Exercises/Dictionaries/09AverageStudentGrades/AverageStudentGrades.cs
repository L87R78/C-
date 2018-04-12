namespace _09AverageStudentGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AverageStudentGrades
    {
        public static void Main()
        {
            var dic = new Dictionary<string, List<double>>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
               
                string name = inputLine[0];
                double grade = double.Parse(inputLine[1]);
                if (!dic.ContainsKey(name))
                {
                    dic.Add(name, new List<double>());
                    dic[name].Add(grade);
                }
                else
                {
                    dic[name].Add(grade);
                }
            }

            foreach (var item in dic)
            {
                string tempStr = null;
                foreach (var value in item.Value)
                {
                    tempStr += value + " ";
                }
                Console.WriteLine($"{item.Key} -> {tempStr.Trim()} (avg: {item.Value.Average():F2})");
            }
        }
    }
}
