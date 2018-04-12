namespace _02StudentCables
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class StudentCables
    {
        static void Main(string[] args)
        {
            int numberCables = int.Parse(Console.ReadLine());

            long sum = 0;
            int count = 0;
            for (int i = 0; i < numberCables; i++)
            {
                int num = int.Parse(Console.ReadLine());
                string lenght = Console.ReadLine();
                if (lenght == "meters")
                {
                    num = num * 100;
                }
             
                if (num >= 20)
                {
                    sum += num;
                    count++;
                }                                    
            } 
            long resultCables = sum - 3 * (count - 1);
            long resultStudents = resultCables / 504;
            long resultEmptyCables = resultCables % 504;
            Console.WriteLine();
            Console.WriteLine(resultStudents);
            Console.WriteLine(resultEmptyCables);
        }
    }
}
