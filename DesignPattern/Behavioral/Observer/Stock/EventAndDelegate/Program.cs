namespace DesignPattern.Behavioral.Observer.Stock.EventAndDelegate
{
    public class Program
    {
        public static void Run()
        {
            // Monitor a stock ticker, when particular events occur, react
            var st = new StockTicker();

            // Create New observers to listen to the stock ticker
            var gf = new GoogleMonitor(st);
            var mf = new MicrosoftMonitor(st);

            // Load the Sample Stock Data
            foreach (var s in SampleData.getNext())
                st.Stock = s;
        }
    }
}
