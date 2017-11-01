using System;

namespace DesignPattern.Behavioral.Observer.Stock.EventAndDelegate
{
    class StockTicker
    {
        private Stock stock;
        public Stock Stock
        {
            get { return stock; }
            set
            {
                stock = value;
                OnStockChange(new StockChangeEventArgs(stock));
            }
        }

        public event EventHandler<StockChangeEventArgs> StockChange;

        protected virtual void OnStockChange(StockChangeEventArgs e)
            => StockChange?.Invoke(this, e);
    }
}
