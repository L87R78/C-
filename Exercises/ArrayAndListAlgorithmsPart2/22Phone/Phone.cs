namespace _22Phone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Phone
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var inputName = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (true)
            {
                var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (command[0].Equals("done"))
                {
                    break;
                }
                if (command[0].Equals("call"))
                {
                    var temp = command[1];

                    if (temp[0] <= 57)
                    {
                        InsertCallInputNumbers(inputNumbers, inputName, temp);
                    }
                    else
                    {
                        InsertCallInputName(inputNumbers, inputName, temp);
                    }
                }
                else if (command[0].Equals("message"))
                {
                    var temp = command[1];

                    if (temp[0] <= 57)
                    {
                        InsertMessageInputNumbers(inputNumbers, inputName, temp);
                    }
                    else
                    {
                        InsertMessageInputName(inputNumbers, inputName, temp);
                    }
                }
            }
        }

        private static void InsertMessageInputName(string[] inputNumbers, string[] inputName, string temp)
        {
            for (int i = 0; i < inputName.Length; i++)
            {
                if (inputName[i] == temp)
                {
                    Console.WriteLine($"sending sms to {inputNumbers[i]}...");

                    var strTemp = inputNumbers[i];
                    long sum = 0;
                    for (int k = 0; k < strTemp.Length; k++)
                    {
                        char num = strTemp[k];
                        if (num >= 48 && num <= 57)
                        {
                            sum += num - '0';
                        }
                    }
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine("meet me there");
                    }
                    else
                    {
                        Console.WriteLine("busy");
                    }

                }
            }
        }

        private static void InsertMessageInputNumbers(string[] inputNumbers, string[] inputName, string temp)
        {
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (inputNumbers[i] == temp)
                {
                    Console.WriteLine($"sending sms to {inputName[i]}...");
                    long sum = 0;
                    var strTemp = inputNumbers[i];
                    for (int sumNum = 0; sumNum < strTemp.Length; sumNum++)
                    {
                        char num = strTemp[sumNum];
                        if (num >= 48 && num <= 57)
                        {
                            sum += num - '0';
                        }
                    }
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine("meet me there");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("busy");
                    }
                }
            }
        }

        private static void InsertCallInputName(string[] inputNumbers, string[] inputName, string temp)
        {
            for (int i = 0; i < inputName.Length; i++)
            {
                if (inputName[i] == temp)
                {
                    Console.WriteLine($"calling {inputNumbers[i]}...");

                    long sum = 0;
                    var strTemp = inputNumbers[i];
                    for (int sumNum = 0; sumNum < strTemp.Length; sumNum++)
                    {
                        char num = strTemp[sumNum];
                        if (num >= 48 && num <= 57)
                        {
                            sum += num - '0';
                        }

                    }
                    if (sum % 2 == 1)
                    {
                        Console.WriteLine("no answer");
                        break;
                    }
                    TimeSpan time = TimeSpan.FromSeconds(sum);

                    if (sum % 2 == 0)
                    {
                        Console.WriteLine("call ended. duration: {0:00}:{1:00}", time.Minutes, time.Seconds);
                    }
                }
            }
        }

        private static void InsertCallInputNumbers(string[] inputNumbers, string[] inputName, string temp)
        {
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (inputNumbers[i] == temp)
                {
                    Console.WriteLine($"calling {inputName[i]}...");
                    long sum = 0;
                    var strTemp = inputNumbers[i];
                    for (int sumNum = 0; sumNum < strTemp.Length; sumNum++)
                    {
                        char num = strTemp[sumNum];
                        if (num >= 48 && num <= 57)
                        {
                            sum += num - '0';
                        }
                    }
                    if (sum % 2 == 1)
                    {
                        Console.WriteLine("no answer");
                        break;
                    }
                    TimeSpan time = TimeSpan.FromSeconds(sum);

                    if (sum % 2 == 0)
                    {
                        Console.WriteLine("call ended. duration: {0:00}:{1:00}", time.Minutes, time.Seconds);
                    }
                }
            }
        }
    }
}