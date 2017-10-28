using System;

namespace DesignPattern.Behavioral.Command.Logging
{
    public class Sample : ISample
    {
        public void Run()
        {
            Console.WriteLine("Without Command Pattern:");
            Program1.Run(new string[] { "UpdateQuantity", "43" });
            Console.WriteLine("With Command Pattern:");
            Program2.Run(new string[] { "UpdateQuantity","43"});
        }
    }
}
