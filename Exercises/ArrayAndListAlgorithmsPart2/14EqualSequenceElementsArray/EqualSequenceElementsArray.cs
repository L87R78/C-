namespace _14EqualSequenceElementsArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class EqualSequenceElementsArray
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();
            bool Iselements = numbers.All(e => e == numbers[0]);

            if (Iselements == true)
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
