using System;

namespace DesignPattern.Behavioral.Observer.Stock.EventAndDelegate
{
    public class StockChangeEventArgs : EventArgs
    {
        public StockChangeEventArgs(Stock s)
        {
            Stock = s;
        }
        public Stock Stock { get; set; }
    }
}
