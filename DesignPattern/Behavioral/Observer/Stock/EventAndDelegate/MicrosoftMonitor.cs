using System;

namespace DesignPattern.Behavioral.Observer.Stock.EventAndDelegate
{
    class MicrosoftMonitor
    {
        public MicrosoftMonitor(StockTicker st)
        {
            st.StockChange += new EventHandler<StockChangeEventArgs>(St_StockChange);
        }

        void St_StockChange(object sender, StockChangeEventArgs e)
        {
            CheckFilter(e.Stock);
        }

        private void CheckFilter(Stock value)
        {
            if (value.Symbol == "MSFT" && value.Price > 10.00m)
                Console.WriteLine($"Microsoft has reached the target price: {value.Price}");
        }
    }
}
