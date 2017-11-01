using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Observer.Stock.Traditional
{
    public class Program
    {
        public static void Run()
        {
            // Monitor a stock ticker, when particular events occur, react
            var subj = new StockTicker();

            // Create New observers to listen to the stock ticker
            var gobs = new GoogleObserver(subj);
            var mobs = new MicrosoftObserver(subj);

            // Load the Sample Stock Data
            foreach (var s in SampleData.getNext())
                subj.Stock = s;
        }
    }
}
