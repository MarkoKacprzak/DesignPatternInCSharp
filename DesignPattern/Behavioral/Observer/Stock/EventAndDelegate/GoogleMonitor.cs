using System;

namespace DesignPattern.Behavioral.Observer.Stock.EventAndDelegate
{
    class GoogleMonitor
    {
        public GoogleMonitor(StockTicker st)
        {
            st.StockChange += new EventHandler<StockChangeEventArgs>(St_StockChange);
        }

        void St_StockChange(object sender, StockChangeEventArgs e)
        {
            CheckFilter(e.Stock);
        }

        private void CheckFilter(Stock value)
        {
            if (value.Symbol == "GOOG")
                Console.WriteLine($"Google's new price is: {value.Price}");
        }
    }
}
