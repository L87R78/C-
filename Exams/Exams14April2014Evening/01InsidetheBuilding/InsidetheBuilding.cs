namespace _01InsidetheBuilding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class InsidetheBuilding
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int[] coordinates = new int[10];
            for (int i = 0; i < 10; i++)
            {
                coordinates[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= 8; i += 2)
            {
                bool a1 = (coordinates[i] >= 0) && (coordinates[i] <= (3 * h)) && (coordinates[i + 1] >= 0) && (coordinates[i + 1] <= h);
                bool b1 = (coordinates[i] >= h) && (coordinates[i] <= (2 * h)) && (coordinates[i + 1] >= h) && (coordinates[i + 1] <= (4 * h));
                bool a1b1 = a1 || b1;
                if (a1b1 == true)
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("outside");
                }
            }
        }
    }
}
