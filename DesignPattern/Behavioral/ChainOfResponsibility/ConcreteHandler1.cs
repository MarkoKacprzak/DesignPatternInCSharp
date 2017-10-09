using System;

namespace DesignPattern.Behavioral.ChainOfResponsibility
{
    /// <summary>
    /// The 'ConcreteHandler1' class
    /// </summary>
    class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine($"{GetType().Name} handled request {request}");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
