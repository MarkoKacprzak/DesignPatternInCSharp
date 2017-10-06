using System;

namespace DesignPattern.Behavioral.ChainOfResponsibility
{
    public class VP : Handler
    {
        public override void handleRequest(Request request)
        {
            if (request.getRequestType() == RequestType.PURCHASE)
            {
                if (request.getAmount() < 1500)
                {
                    Console.WriteLine("VPs can approve purchases below 1500");
                }
                else if (successor != null)
                {
                    successor.handleRequest(request);
                }
            }
        }
    }
}
