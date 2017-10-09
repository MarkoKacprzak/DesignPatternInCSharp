using System;

namespace DesignPattern.Behavioral.ChainOfResponsibility
{
    /// <summary>
    /// The 'ConcreteHandler3' class
    /// </summary>
    class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine("${GetType().Name} handled request {request}");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
