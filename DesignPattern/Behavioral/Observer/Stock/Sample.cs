using System;

namespace DesignPattern.Behavioral.Observer.Stock
{
    public class Sample : ISample
    {
        public void Run()
        {
            Console.WriteLine("Motivation:");
            MotivatingExample.Program.Run();
            Console.WriteLine("Traditional:");
            Traditional.Program.Run();
            Console.WriteLine("Event and delegate:");
            EventAndDelegate.Program.Run();
            Console.WriteLine("IObserver:");
            IObserver.Program.Run();
        }
    }
}
