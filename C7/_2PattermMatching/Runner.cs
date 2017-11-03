using static System.Console;

namespace C7._2PattermMatching
{
    public class Runner: IRunner
    {
        public void Run()
        {
            Employee theEmployee = new VicePresident();
            theEmployee.Salary = 175000;
            theEmployee.Years = 7;
            (theEmployee as VicePresident).NumberManaged = 200;
            (theEmployee as VicePresident).StockShares = 6000;

            switch (theEmployee)
            {
                case VicePresident vp when (vp.StockShares < 5000):
                    WriteLine($"Junior VP with {vp.StockShares} shares");
                    break;

                case VicePresident vp when (vp.StockShares >= 5000):
                    WriteLine($"Senior VP with {vp.StockShares} shares");
                    break;

                case Manager m:
                    WriteLine($"Manager with {m.NumberManaged} reporting");
                    break;
                case Employee e:
                    WriteLine($"Employee with salary {e.Salary}");
                    break;

 
            }
        }
    }
}
