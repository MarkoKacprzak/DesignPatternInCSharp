using System;

namespace DesignPattern.Behavioral.ChainOfResponsibility
{
    /// <summary>
    /// The 'ConcreteHandler2' class
    /// </summary>
    class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
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
