namespace _16ArraySymmetry
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ArraySymmetry
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split().ToArray();

            bool IsSymmetric = true;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == words[words.Length - 1 - i])
                {

                }
                else
                {
                    IsSymmetric = false;
                }
            }
            if (IsSymmetric == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
