namespace _01WorkHours
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class WorkHours
    {
        public static void Main()
        {
            int workHours = int.Parse(Console.ReadLine());
            int daysFinish = int.Parse(Console.ReadLine());
            int productivity = int.Parse(Console.ReadLine());

            double  workVanche = (daysFinish * 0.90) * 12;
            double productivityResult = Math.Floor((workVanche * productivity) / 100);
            double finishProject = productivityResult - workHours;
            Console.WriteLine();
            if (finishProject >= 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine(finishProject);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine(finishProject);
            }     
        }
    }
}
