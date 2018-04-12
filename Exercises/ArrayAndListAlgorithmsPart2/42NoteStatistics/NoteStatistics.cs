namespace _42NoteStatistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class NoteStatistics
    {
        static void Main()
        {
            var list = new List<string>();
            list.Add("C 261.63");
            list.Add("C# 277.18");
            list.Add("D 293.66");
            list.Add("D# 311.13");
            list.Add("E 329.63");
            list.Add("F 349.23");
            list.Add("F# 369.99");
            list.Add("G 392.00");
            list.Add("G# 415.30");
            list.Add("A 440.00");
            list.Add("A# 466.16");
            list.Add("B 493.88");

            var listNotes = new List<string>();
            var listNarurals = new List<string>();
            var listSharp = new List<string>();
            var listNaturalSum = new List<double>();
            var listSharpSum = new List<double>();

            var inpuLine = Console.ReadLine().Split();

            for (int i = 0; i < inpuLine.Length; i++)
            {
                var numInput = inpuLine[i].Split('.');
                string nums = numInput[0];
                foreach (var text in list)
                {
                    var textSplit = text.Split();
                    var splitTextSplit = textSplit[1].Split('.');


                    if (nums == splitTextSplit[0])
                    {
                        listNotes.Add(textSplit[0]);
                        if (textSplit[0].Length == 1)
                        {
                            listNarurals.Add(textSplit[0]);
                            listNaturalSum.Add(double.Parse(textSplit[1]));
                        }
                        else if (textSplit[0].Length == 2)
                        {
                            listSharp.Add(textSplit[0]);
                            listSharpSum.Add(double.Parse(textSplit[1]));
                        }
                    }
                }

            }
            Console.WriteLine("Notes: {0}", string.Join(" ", listNotes));
            Console.WriteLine("Naturals: {0}", string.Join(", ", listNarurals));
            Console.WriteLine("Sharps: {0}", string.Join(", ", listSharp));
            Console.WriteLine("Naturals sum: {0}", string.Join(" ", listNaturalSum.Sum()));
            Console.WriteLine("Sharps sum: {0}", string.Join(" ", listSharpSum.Sum()));
        }
    }
}
