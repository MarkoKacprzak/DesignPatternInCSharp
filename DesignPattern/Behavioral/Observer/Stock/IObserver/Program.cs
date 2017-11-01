namespace DesignPattern.Behavioral.Observer.Stock.IObserver
{
    public class Program
    {
        public static void Run()
        {
            // Monitor a stock ticker, when particular events occur, react
            var st = new StockTicker();

            var gf = new GoogleMonitor();
            var mf = new MicrosoftMonitor();

            using (st.Subscribe(gf))
            using (st.Subscribe(mf))
            {
                // Load the Sample Stock Data
                foreach (var s in SampleData.getNext())
                    st.Stock = s;
            }

        }
    }
}
