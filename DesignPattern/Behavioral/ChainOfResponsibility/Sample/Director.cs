using System;

namespace DesignPattern.Behavioral.ChainOfResponsibility.Sample
{
    public class Director : Handler
    {
        public override void handleRequest(Request request)
        {
            if (request.getRequestType() == RequestType.CONFERENCE)
            {
                Console.WriteLine("Directors can approve conferences");
            }
            else if (successor != null)
            {
                successor.handleRequest(request);
            }
        }
    }

}
