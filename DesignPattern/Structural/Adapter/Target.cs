using System;

namespace DesignPattern.Structural.Adapter
{
    /// <summary>
    /// The 'Target' class
    /// </summary>
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }
}
