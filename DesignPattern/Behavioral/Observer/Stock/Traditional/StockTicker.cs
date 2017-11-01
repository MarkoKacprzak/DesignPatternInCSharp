namespace DesignPattern.Behavioral.Observer.Stock.Traditional
{
    public class StockTicker : AbstractSubject
    {
        private Stock stock;
        public Stock Stock
        {
            get { return stock; }
            set
            {
                stock = value;
                Notify();
            }
        }
    }
}
