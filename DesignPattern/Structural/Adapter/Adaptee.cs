using System;

namespace DesignPattern.Structural.Adapter
{
    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}
