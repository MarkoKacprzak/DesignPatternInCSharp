using System;

namespace DesignPattern.Behavioral.ChainOfResponsibility
{
    public class CEO : Handler
    {
        public override void handleRequest(Request request)
        {
            Console.WriteLine("CEOs can approve anything they want");
        }
    }
}
