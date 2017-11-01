using System;

namespace DesignPattern.Behavioral.Observer.Stock.Traditional
{
    public class GoogleObserver : AbstractObserver
    {
        public GoogleObserver(StockTicker subj)
        {
            DataSource = subj;
            subj.Register(this);
        }
        private StockTicker DataSource { get; set; }
        public override void Update()
        {
            var price = DataSource.Stock.Price;
            var symbol = DataSource.Stock.Symbol;

            // Reactive Filters
            if (symbol == "GOOG")
                Console.WriteLine("Google's new price is: {0}", price);
        }
    }
}
