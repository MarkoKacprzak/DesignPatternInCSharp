using System;

namespace DesignPattern.Behavioral.Observer.Stock.MotivatingExample
{
    public class Program
    {
        public static void Run()
        {
            // Monitor a stock ticker, when particular events occur, react
            foreach (Stock s in SampleData.getNext())
            {
                // Reactive Filters
                if (s.Symbol == "GOOG")
                    Console.WriteLine($"Google's new price is: {s.Price}");

                if (s.Symbol == "MSFT" && s.Price > 10.00m)
                    Console.WriteLine($"Microsoft has reached the target price: {s.Price}");

                if (s.Symbol == "XOM")
                    Console.WriteLine($"Exxon mobile's price is {s.Price}");
            }
        }
    }
}
