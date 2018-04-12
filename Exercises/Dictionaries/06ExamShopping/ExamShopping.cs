namespace _06ExamShopping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ExamShopping
    {
        public static void Main()
        {
            var dicStock = new Dictionary<string, long>();
            while (true)
            {
                var inputLine = Console.ReadLine().Split();
                if (inputLine[0] == "shopping")
                {
                    break;
                }
                string stockName = inputLine[1];
                long priceStock = long.Parse(inputLine[2]);

                if (!dicStock.ContainsKey(stockName))
                {
                    dicStock.Add(stockName, 0);
                    dicStock[stockName] = priceStock;
                }
                else
                {
                    dicStock[stockName] += priceStock;
                }
            }

            while (true)
            {
                var secondInputLine = Console.ReadLine().Split();
                if (secondInputLine[0] == "exam")
                { 
                    break;
                }
                string searchStockName = secondInputLine[1];
                long searchStockPrice = long.Parse(secondInputLine[2]);

                bool IsSearch = dicStock.Keys.Any(x => x == searchStockName);
                if (IsSearch == true)
                {
                    foreach (var item in dicStock)
                    {
                        if (item.Key == searchStockName)
                        {
                          
                            long numStock = item.Value;
                            if (numStock <= 0)
                            {
                                Console.WriteLine($"{searchStockName} out of stock");
                            }
                            long result = item.Value - searchStockPrice;
                            if (result <= 0)
                            {
                                dicStock[item.Key] = 0;
                            }
                            else
                            {
                                dicStock[item.Key] = result;
                            }
                            break;
                        }
                    }        
                }
                else
                {
                    Console.WriteLine($"{searchStockName} doesn't exist");
                }
            }
     
            foreach (var item in dicStock)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }
    }
}
