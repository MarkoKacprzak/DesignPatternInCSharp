﻿using System;

namespace DesignPattern.Behavioral.Observer.Stock.IObserver
{
    class MicrosoftMonitor : IObserver<Stock>
    {
        public void OnCompleted()
        {
            Console.WriteLine("End of trading day");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Error occured in the stock ticker");
        }

        public void OnNext(Stock value)
        {
            if (value.Symbol == "MSFT" && value.Price > 10.00m)
                Console.WriteLine($"Microsoft has reached the target price: {value.Price}");
        }
    }
}
